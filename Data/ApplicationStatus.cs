using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1var.Data
{
    public class ApplicationStatus
    {
        [Key]
        public int StatusId { get; set; } // Первичный ключ

        public string Status { get; set; }
    }
}
