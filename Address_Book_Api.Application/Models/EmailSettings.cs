﻿
namespace Address_Book_Api.Application.Models
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int SmtpPort{ get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword{ get; set; }
    }
}
