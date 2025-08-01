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
                    About= "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                    Contacts="082 281 3576",
                    Website= "https://www.example.com",
                    Email="rambuwani@outlook.co.za",
                    ImageUrl = "https://as2.ftcdn.net/jpg/03/83/25/83/1000_F_383258331_D8imaEMl8Q3lf7EKU2Pi78Cn0R7KkW9o.jpg"

                },
                new AddressBook
                   {
                       Firstname = "Thendo",
                       Surname = "Roma",
                    About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                    Contacts = "082 123 3576",
                       Website = "https://www.example.com/blog/article-title",
                       Email = "twam@outlook.co.za",
                       ImageUrl= "https://as1.ftcdn.net/v2/jpg/02/43/12/34/1000_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg"

                },
                         new AddressBook
                         {
                             Firstname = "Denzhe",
                             Surname = "Marubini",
                             About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                             Contacts = "063 111 3467",
                             Website = "https://www.example.com/blog/article-title",
                             Email = "twam@outlook.co.za",
                             ImageUrl = "https://as1.ftcdn.net/v2/jpg/03/02/88/46/1000_F_302884605_actpipOdPOQHDTnFtp4zg4RtlWzhOASp.jpg"

                         },
                                  new AddressBook
                                  {
                                      Firstname = "Jane",
                                      Surname = "Masindi",
                                      About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                                      Contacts = "082 123 3576",
                                      Website = "https://www.example.com/blog/article-title",
                                      Email = "twam@outlook.co.za",
                                      ImageUrl = "https://as1.ftcdn.net/v2/jpg/02/43/76/54/1000_F_243765470_a0hN5zuTKIonTbRGldi8KajuvhSiWvDx.jpg"

                                  },
                                           new AddressBook
                                           {
                                               Firstname = "Tshililo",
                                               Surname = "Masinidi",
                                               About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                                               Contacts = "082 999 4444",
                                               Website = "https://www.example.com/blog/article-title",
                                               Email = "twam@outlook.co.za",
                                               ImageUrl = "https://as2.ftcdn.net/v2/jpg/01/87/53/55/1000_F_187535523_i1AuPUR5LG5o8wu2JLlFpWPoAjYGj1xH.jpg"

                                           },
                                                    new AddressBook
                                                    {
                                                        Firstname = "Selina",
                                                        Surname = "Muna",
                                                        About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                                                        Contacts = "028 456 0924",
                                                        Website = "https://www.example.com/blog/article-title",
                                                        Email = "twam@outlook.co.za",
                                                        ImageUrl = "https://as1.ftcdn.net/v2/jpg/05/86/65/86/1000_F_586658640_LoqbtbLWRWdrY9LoydA0L6tuoDZdjl93.jpg"

                                                    },
                                                             new AddressBook
                                                             {
                                                                 Firstname = "Orilwela",
                                                                 Surname = "Masindi",
                                                                 About = "There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                                                                 Contacts = "072 133 5678",
                                                                 Website = "https://www.example.com/blog/article-title",
                                                                 Email = "twam@outlook.co.za",
                                                                 ImageUrl = "https://as1.ftcdn.net/v2/jpg/01/80/70/48/1000_F_180704843_lo6Lp2A1AmPNXgECoOfLx2XLhGLcQ1N1.jpg"

                                                             }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
