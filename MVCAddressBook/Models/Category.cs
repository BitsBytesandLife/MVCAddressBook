using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ContactId { get; set; }

        public string Name { get; set; }

        //Profile Image
        [Display(Name = "Category Picture")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public ICollection<Contact> Contact { get; set; } = new HashSet<Contact>();

        

    }
}
