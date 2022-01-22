using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Models
{
        [Index(nameof(Email), IsUnique = true)]

        public class Customer 
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; } = null!;

            [Required]
            [StringLength(50)]
            public string LastName { get; set; } = null!;

            [Required]
            [StringLength(100)]
            [Unicode(false)]
            public string Email { get; set; } = null!;

       
            [Required]
            public int ErrandId { get; set; }

            public string DisplayName => $"{FirstName} {LastName}";


        [Required]
        [StringLength(50)]
        public string StreetName { get; set; } = null!;


        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string PostalCode { get; set; } = null!;


        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!;


        public virtual ICollection<Errand> Errands { get; set; } = new List<Errand>();
    }
}


