using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Entities.Concrete
{
    public class Cart
    {
        /// <summary>
        /// Sepet işlemlerinin oldugu entity...Burada constructor içerisinde CartItem,O anın tarihi,ve sepetin aktif oldugu belirtmek icin default değerler verdik.
        /// </summary>
        public Cart()
        {
            Products = new List<CartItem>();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }

        public Guid Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual List<CartItem> Products { get; set; }
        public bool IsActive { get; set; }
    }
}

