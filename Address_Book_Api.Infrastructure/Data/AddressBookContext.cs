using Address_Book_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Address_Book_Api.Infrastructure.Data
{
    public class AddressBookContext: DbContext
    {
        public AddressBookContext(DbContextOptions<AddressBookContext> options) 
            : base(options)
        {
        }

        public virtual DbSet<AddressBook> AddressBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressBook>().HasData(

                new AddressBook {
                    Firstname="Tsireledzo", 
                    Surname="Rambuwani",
                    About=" Tsire is loving and kind",
                    Contacts="082 281 3576",
                    Website="www.ifo.co.za",
                    Email="rambuwani@outlook.co.za",
                    ImageUrl = "https://www.google.com/imgres?q=people%20image%20face&imgurl=https%3A%2F%2Ft3.ftcdn.net%2Fjpg%2F05%2F67%2F87%2F62%2F360_F_567876282_iUMkcDC6CgrX8AI5Mh72VQZQqFYzv7aM.jpg&imgrefurl=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dpeople%2Bfaces&docid=nPEMc-gjV6EuAM&tbnid=m0-35iWXEnYaSM&vet=12ahUKEwjH5--8iOeOAxVpaEEAHV6dJtIQM3oECBkQAA..i&w=540&h=360&hcb=2&ved=2ahUKEwjH5--8iOeOAxVpaEEAHV6dJtIQM3oECBkQAA"

                },
                new AddressBook
                   {
                       Firstname = "Tendo",
                       Surname = "Tom",
                       About = " Team is loving and kind",
                       Contacts = "082 123 3576",
                       Website = "www.look.co.za",
                       Email = "twam@outlook.co.za",
                       ImageUrl= "https://www.istockphoto.com/photo/portrait-of-a-confident-young-woman-at-the-park-gm1191193169-337953035?utm_campaign=srp_photos_top&utm_content=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fpeople-face&utm_medium=affiliate&utm_source=unsplash&utm_term=people+face%3A%3Ano-top-affiliates%3Acontrol"

                }

            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
