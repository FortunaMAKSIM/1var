using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1var.Data
{
    public class StatusHistory
    {
        [Key]
        public int ChangeId { get; set; } // Первичный ключ

        [ForeignKey("Applica")]
        public int ApplicationId { get; set; } // Внешний ключ к таблице Applica

        public DateTime ChangeDate { get; set; } // DateTime для хранения даты

        [ForeignKey("ApplicationStatus")]
        public int NewStatusId { get; set; } // Внешний ключ к таблице ApplicationStatus

        // Навигационные свойства
        public virtual Applica Applica { get; set; }
        public virtual ApplicationStatus ApplicationStatus { get; set; }
    }
}
