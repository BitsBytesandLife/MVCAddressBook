using MVCAddressBook.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        [Display (Name = "First Name:")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
        [Display(Name = "Street:")]
        public string StreetAddress { get; set; }
        [Display(Name = "City:")]
        public string City { get; set; }
        [Display(Name = "State:")]
        public States State { get; set; }
        [Display(Name = "Home Phone:")]
        public string HomePhone { get; set; }
        [Display(Name = "Work Phone:")]
        public string  WorkPhone { get; set; }
        [Display(Name = "Cell Phone:")]
        public string CellPhone { get; set; }
        [Display(Name = "Fax Number:")]
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        //Profile Image
        [Display(Name = "Profile Pic")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public int CategoryId { get; set; }

        public Category Category {get; set; } 


    }
}
