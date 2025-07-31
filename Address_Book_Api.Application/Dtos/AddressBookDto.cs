
using System.ComponentModel.DataAnnotations;

namespace Address_Book_Api.Application.Dtos
{
    public class AddressBookDto
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Website { get; set; }

        [Phone]
        public string Contacts { get; set; }
        public  string ImageUrl { get; set; }

    }
}
