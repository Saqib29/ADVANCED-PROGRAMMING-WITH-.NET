using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classPerformance1.Models
{
    public class Form
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public HttpPostedFileBase ProfilePicture { get; set; }
        public string ImageName { get; set; }
    }
}