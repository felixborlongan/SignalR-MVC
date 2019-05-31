using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRModel
{
    [Table("Chats", Schema = "dbo")]
    public class Chat
    {
        [Key]
        public int ChatID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
