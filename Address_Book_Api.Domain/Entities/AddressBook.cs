
using System.ComponentModel.DataAnnotations;

namespace Address_Book_Api.Domain.Entities
{
    public class AddressBook
    {
        [Key]
        public Guid Id { get; set; }  =Guid.NewGuid();
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        public string About { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Website { get; set; }

        [Phone]
        public string Contacts { get; set; }
        public string ImageUrl { get; set; }
    }
}
