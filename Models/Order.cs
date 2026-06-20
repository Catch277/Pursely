using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SportSln.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        [Required(ErrorMessage = "Vui lòng nhập tên người nhận")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Phường/Xã")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Tỉnh/Thành phố")]
        public string? State { get; set; }
        public string? Zip { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Quốc gia")]
        public string? Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
