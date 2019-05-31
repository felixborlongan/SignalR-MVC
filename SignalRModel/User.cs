using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRModel
{
    [Table("Users", Schema = "dbo")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}
