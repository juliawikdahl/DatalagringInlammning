using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Models
{
    
    public class Errand
    {

        [Required]
        public int CustomerId { get; set; }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]

        [StringLength(150)]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        [Required]
        public State State { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        
    }
    public enum State
    {

        NotRunning,
        UnderProcess,
        Stopped

    }
}
