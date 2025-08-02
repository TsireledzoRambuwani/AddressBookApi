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
                    Id= new Guid("2eb8d354-ae1b-424a-90eb-30517b0d01e5"),
                    Firstname="Tsireledzo", 
                    Surname="Rambuwani",
                    About= "I am Proactive and detail-oriented individual with a passion for IT. " +
                    "Seeking an entry-level position to utilize my strong communication and interpersonal skills, " +
                    "and contribute to a team's success." +
                    "There are many variations of passages of Lorem Ipsum available, " +
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
                    Email="rambuwanitsireledzo@gmail.com",
                    ImageUrl = "https://as2.ftcdn.net/jpg/03/83/25/83/1000_F_383258331_D8imaEMl8Q3lf7EKU2Pi78Cn0R7KkW9o.jpg"

                },
                new AddressBook
                   {
                    Id = new Guid("c9243089-ecea-49a8-860f-6fa561d324ee"),
                    Firstname = "Thomas",
                       Surname = "Nel",
                    About = "Highly motivated and results-driven recent graduate with a background in IT. " +
                    "Eager to apply my knowledge of IT and contribute to a challenging and rewarding career .There are many variations of passages of Lorem Ipsum available, " +
                    "but the majority have suffered alteration in some form, by injected humour, " +
                    "or randomised words which don't look even slightly believable. If you are going " +
                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                    "injected humour, or non-characteristic words etc",
                    Contacts = "082 123 3576",
                       Website = "https://www.example.com/contact",
                       Email = "thendor@outlook.co.za",
                       ImageUrl= "https://as1.ftcdn.net/v2/jpg/02/43/12/34/1000_F_243123463_zTooub557xEWABDLk0jJklDyLSGl2jrr.jpg"

                },
                         new AddressBook
                         {
                             Id = new Guid("67ff3aa3-7ebf-47d1-8dd3-5d49e294f9cd"),
                             Firstname = "Sharon",
                             Surname = "Renano",
                             About = "Seasoned marketing professional with 8+ years of experience driving successful marketing campaigns. " +
                             "Proven ability to increase brand awareness, generate leads, and boost revenue. Expertise in IT " +
                             "and a strong track record of achieving results. There are many variations of passages of Lorem Ipsum available, " +
                            "but the majority have suffered alteration in some form, by injected humour, " +
                            "or randomised words which don't look even slightly believable. If you are going " +
                            "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                            "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                            " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                            " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                            " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                            "injected humour, or non-characteristic words etc",
                             Contacts = "063 111 3467",
                             Website = "https://accounts.example.com/login",
                             Email = "denzheM@outlook.co.za",
                             ImageUrl = "https://as1.ftcdn.net/v2/jpg/03/02/88/46/1000_F_302884605_actpipOdPOQHDTnFtp4zg4RtlWzhOASp.jpg"

                         },
                                  new AddressBook
                                  {
                                      Id = new Guid("b2f73f53-cc41-406b-b710-135aa9781f2f"),
                                      Firstname = "Jane",
                                      Surname = "Masindi",
                                      About = "Results-driven financial analyst with 6+ years of experience in IT." +
                                      " Expertise in IT modeling, forecasting, and analysis. Seeking a challenging role where I can utilize my skills to drive financial performance." +
                                      " There are many variations of passages of Lorem Ipsum available, " +
                                        "but the majority have suffered alteration in some form, by injected humour, " +
                                        "or randomised words which don't look even slightly believable. If you are going " +
                                        "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                                        "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                                        " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                                        " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                                        " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                                        "injected humour, or non-characteristic words etc",
                                      Contacts = "082 123 3576",
                                      Website = "https://twitter.com/example_user",
                                      Email = "janeM@outlook.co.za",
                                      ImageUrl = "https://as1.ftcdn.net/v2/jpg/02/43/76/54/1000_F_243765470_a0hN5zuTKIonTbRGldi8KajuvhSiWvDx.jpg"

                                  },
                                           new AddressBook
                                           {
                                               Id = new Guid("056d83b5-0da6-40bf-a07b-d8ddb8a07ea1"),
                                               Firstname = "Sandra",
                                               Surname = "Holy",
                                               About = " Results-oriented project manager with 10+ years of experience in IT. Adept at leading cross-functional teams, " +
                                               "managing projects from initiation to completion, and delivering projects on time and within budget. " +
                                               "Proven ability to identify and mitigate risks. There are many variations of passages of Lorem Ipsum available, " +
                                            "but the majority have suffered alteration in some form, by injected humour, " +
                                            "or randomised words which don't look even slightly believable. If you are going " +
                                            "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                                            "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                                            " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                                            " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                                            " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                                            "injected humour, or non-characteristic words etc",
                                               Contacts = "082 999 4444",
                                               Website = "https://example.com/page?id=123&user=456",
                                               Email = "tshililoM@outlook.co.za",
                                               ImageUrl = "https://as2.ftcdn.net/v2/jpg/01/87/53/55/1000_F_187535523_i1AuPUR5LG5o8wu2JLlFpWPoAjYGj1xH.jpg"

                                           },
                                                    new AddressBook
                                                    {
                                                        Id = new Guid("189aa699-0c93-4594-abe1-6e532788eb47"),
                                                        Firstname = "Melody",
                                                        Surname = "Thami",
                                                        About = "Highly skilled IT professional with 5+ years of experience in Development. Expertise in C#" +
                                                        " and a strong understanding of IT infrastructure and security. Eager to leverage my technical expertise to contribute to a leading technology company. " +
                                                        "There are many variations of passages of Lorem Ipsum available, " +
                                                    "but the majority have suffered alteration in some form, by injected humour, " +
                                                    "or randomised words which don't look even slightly believable. If you are going " +
                                                    "to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing " +
                                                    "hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat" +
                                                    " predefined chunks as necessary, making this the first true generator on the Internet. It uses a" +
                                                    " dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate" +
                                                    " Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, " +
                                                    "injected humour, or non-characteristic words etc",
                                                        Contacts = "028 456 0924",
                                                        Website = "https://example.com/page?id=123&user=410",
                                                        Email = "selinaM@outlook.co.za",
                                                        ImageUrl = "https://as1.ftcdn.net/v2/jpg/05/86/65/86/1000_F_586658640_LoqbtbLWRWdrY9LoydA0L6tuoDZdjl93.jpg"

                                                    },
                                                             new AddressBook
                                                             {
                                                                 Id = new Guid("68e32c7d-5cfc-4d79-94fd-d50f994f5fce"),
                                                                 Firstname = "Renato",
                                                                 Surname = "Masindi",
                                                                 About = "Dedicated and compassionate healthcare professional with 7+ years of experience in IT. Expertise in IT and a commitment to providing high-quality patient care. " +
                                                                 "Seeking a challenging and rewarding role in a patient-focused environment. There are many variations of passages of Lorem Ipsum available, " +
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
                                                                 Email = "orilwelaM@outlook.co.za",
                                                                 ImageUrl = "https://as1.ftcdn.net/v2/jpg/03/27/32/88/1000_F_327328852_ySk6Y8cXuLrApZT5slqddPuw29acSqCG.jpg"

                                                             }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
