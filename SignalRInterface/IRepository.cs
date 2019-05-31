using SignalRModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SignalRInterface
{
    public interface IRepository
    {
        DbSet<User> Users { get; set; }
        DbSet<Chat> Chats { get; set; }
        int SaveChanges();
    }
}
