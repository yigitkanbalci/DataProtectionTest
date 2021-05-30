using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataProtectionTest.Models
{
    public partial class Book
    {
        [NotMapped]
        public string EncryptedId { get; set; }
    }
}
