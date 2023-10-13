
using System.ComponentModel.DataAnnotations;

namespace AllUp.ViewModels
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Bos ola bilmez!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Bos ola bilmez!")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Bos ola bilmez!")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Bos ola bilmez!")]
        public string? Message { get; set; }
    }
}
