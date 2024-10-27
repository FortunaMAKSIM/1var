using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1var.Data
{
    public class Equipment
    {
        [Key]
        public float EquipmentId { get; set; } // Первичный ключ

        public string Category { get; set; }
        public string EquipName { get; set; }
    }
}
