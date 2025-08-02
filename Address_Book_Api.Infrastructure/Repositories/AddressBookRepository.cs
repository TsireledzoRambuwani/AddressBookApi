using Address_Book_Api.Application.Dtos;
using Address_Book_Api.Application.Interfaces;
using Address_Book_Api.Application.Models;
using Address_Book_Api.Application.Services;
using Address_Book_Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Address_Book_Api.Infrastructure.Repositories
{
    public class AddressBookRepository(AddressBookContext context,
        IEmailService emailService) : IAddressBookRepository
    {
        private readonly AddressBookContext _context = context;
        private readonly IEmailService _emailService = emailService;
        public async Task<IEnumerable<AddressBookDto>> GetAllAsync()
        {
            var addressBooks = await _context.AddressBooks.ToListAsync();

            return addressBooks.Select(x => new AddressBookDto
            {
                Id =x.Id.ToString(),
                Firstname =x.Firstname,
                About=x.About,
                Contacts=x.Contacts,
                Email=x.Email,
                ImageUrl =x.ImageUrl,
                Surname=x.Surname,
                Website=x.Website,

                

            }).ToList();
         }



        public async Task<RepositoryResponse> RequestCVAsync(string id)
        {
            var profile = await GetByIdAsync(id);

            if (profile is null)
                return new RepositoryResponse { Error = "Cound not find Address Book.", Succeeded = false };

            bool isMailSent = await RequectCVEmail(profile);

            if (!isMailSent)
                return new RepositoryResponse { Error = "Cound not Send email, Please contact Administrator.", Succeeded = false };


            return new RepositoryResponse { Succeeded = true };

        }

        private async Task<bool> RequectCVEmail(AddressBookDto profile)
        {
            string emailBody = GetEmailBody(profile);

            var isMailSent = await _emailService.SendEmailAsync(profile.Email, "Request CV", emailBody);
            return isMailSent;
        }

        private async Task<AddressBookDto> GetByIdAsync(string id)
        {
            var addressBooks = await _context.AddressBooks
                            .Where(x => x.Id.Equals(new Guid(id.ToLower())))
                            .FirstOrDefaultAsync();

            if (addressBooks is  null) return new AddressBookDto();

            return new AddressBookDto
            {
                Id = addressBooks.Id.ToString(),
                Firstname = addressBooks.Firstname,
                About = addressBooks.About,
                Contacts = addressBooks.Contacts,
                Surname = addressBooks.Surname,
                ImageUrl = addressBooks.ImageUrl,
                Website = addressBooks.Website,
                Email = addressBooks.Email,


            };
        }

        private static string GetEmailBody(AddressBookDto profile)
        {
            string templatePath = Path.Combine(Directory.GetCurrentDirectory() + ".Infrastructure", "EmailTemplate", "CVRequestEmail.html");
            string emailBody = File.ReadAllText(templatePath);

            emailBody.Replace("{{Firstname}}", profile.Firstname)
                     .Replace("{{Surname}}", profile.Surname)
                     .Replace("{{Website}}", profile.Website);

        return emailBody;
        }
    }
}
