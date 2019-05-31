using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SignalRInterface;
using SignalRModel;

namespace SignalRDAL
{
    public class DBContext : DbContext, IRepository
    {
        public DBContext() : base("DefaultConnection")
        {
            Database.SetInitializer<DBContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
