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
            get { return EquipmentDb.HasValue ? (int)EquipmentDb.Value : (int?)null; } // Преобразуем float в int
            set { EquipmentDb = value.HasValue ? (float?)value.Value : null; } // Сохраняем значение как float
        }

        public string? FaultType { get; set; }
        public string? ProblemDesc { get; set; }

        // Внешний ключ на исполнителя
        [ForeignKey("Staff")]
        public int? ExecutorId { get; set; }

        public string? CauseOfMalfunction { get; set; }
        public int? ExecCost { get; set; }

        // Навигационные свойства (опционально)
        public virtual Client Client { get; set; }
        public virtual Staff Staff { get; set; }

        // Метод для получения значения EquipmentId с учетом возможного null
        public int GetEquipmentIdOrDefault()
        {
            return EquipmentId ?? 0; // Возвращаем 0, если EquipmentId равно null
        }
    }
}
