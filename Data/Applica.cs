using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1var.Data
{
    public class Applica
    {
        // Установка первичного ключа
        [Key]
        public int Number { get; set; }

        // Внешний ключ на клиента
        [ForeignKey("Client")]
        public int? ClientId { get; set; }

        public string? Priority { get; set; }
        public DateTime? AddDate { get; set; }

        // Свойство, которое хранит float в базе данных
        [NotMapped]
        public float? EquipmentDb { get; set; } // Связывается с БД

        // Свойство, с которым будете работать в коде
        public int? EquipmentId
        {
            get { return (int)(EquipmentDb ?? 0); } // Преобразуем float в int
            set { EquipmentDb = value; } // Сохраняем значение как float
        }

        public string? FaultType { get; set; }
        public string? ProblemDesc { get; set; }

        // Внешний ключ на исполнителя
        [ForeignKey("Staff")]
        public int? ExecutorId { get; set; }

        public string? CauseOfMalfunction { get; set; }
        public int? ExecCost { get; set; }

        // Навигационные свойства
        public virtual Client Client { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
