using ePizza.Entities.Concrete;
using ePizza.Repositories.Interfaces;
using ePizza.Services.Interfaces;
using ePizza.Services.Models;
using Microsoft.Extensions.Options;
using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Implemantations
{
    public class PaymentManager : IPaymentService
    {

        private readonly IOptions<RazorPayConfig> _razorPayConfig;
        private readonly RazorpayClient _client;
        readonly IRepository<PaymentDetails> _repository;
        readonly ICartRepository _cartRepository;

        public PaymentManager(IOptions<RazorPayConfig> razorPayConfig, IRepository<PaymentDetails> repository,  ICartRepository cartRepository)
        {
            _razorPayConfig = razorPayConfig;
            _repository = repository;
            _cartRepository = cartRepository;
            _client ??= new RazorpayClient(_razorPayConfig.Value.Key, _razorPayConfig.Value.Secret);

        }
        public string CreateOrder(decimal amount, string currency, string receipt)
        {
            try
            {
                Dictionary<string, object> options = new Dictionary<string, object>
                {
                    { "amount", amount },
                    { "currency", currency },
                    { "receipt", receipt },
                    { "payment_capture", 1 }
                };

                Razorpay.Api.Order orderResponse = _client.Order.Create(options);
                return orderResponse["id"].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string CapturePayment(string paymentId, string orderId)
        {
            if (!string.IsNullOrWhiteSpace(paymentId) && !String.IsNullOrWhiteSpace(orderId))
            {
                try
                {
                    Payment payment = _client.Payment.Fetch(paymentId);
  
                    Dictionary<string, object> options = new Dictionary<string, object>();
                    options.Add("amount", payment.Attributes["amount"]);
                    options.Add("currency", payment.Attributes["currency"]);
                    Payment paymentCaptured = payment.Capture(options);
                    return paymentCaptured.Attributes["status"];
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            }
            return null;
        }

        public Payment GetPaymentDetails(string paymentId)
        {
            if (!string.IsNullOrWhiteSpace(paymentId))
            {
                return _client.Payment.Fetch(paymentId);
            }
            return null;
        }
        public bool VerifySignature(string signature, string orderId, string paymentId)
        {
            string payload = $"{orderId}|{paymentId}";
            string secret = RazorpayClient.Secret;
            string actualSignature = getActualSignature(payload, secret);
            return actualSignature.Equals(signature);
        }

        private static string getActualSignature(string payload, string secret)
        {
            byte[] secretBytes = StringEncode(secret);
            HMACSHA256 hashHmac = new HMACSHA256(secretBytes);
            var bytes = StringEncode(payload);

            return HashEncode(hashHmac.ComputeHash(bytes));
        }

        private static byte[] StringEncode(string text)
        {
            var encoding = new ASCIIEncoding();
            return encoding.GetBytes(text);
        }

        private static string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public async Task<int> SavePaymentDetails(PaymentDetails model)
        {
            await _repository.AddAsync(model);
            var cart = _cartRepository.FindAsync(model.CartId);
            cart.Result.IsActive = false;
            return await _repository.SaveAsync();
        }

    }
}
