using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1var.Data
{
    public class ApplicationComment
    {
        [Key]
        public int CommentId { get; set; } // Первичный ключ

        [ForeignKey("Applica")]
        public int ApplicationId { get; set; } // Внешний ключ к таблице Applica

        public DateTime CreationDate { get; set; } // DateTime для хранения даты
        public string Text { get; set; }
        public string Author { get; set; }

        // Навигационные свойства
        public virtual Applica Applica { get; set; }
    }
}
