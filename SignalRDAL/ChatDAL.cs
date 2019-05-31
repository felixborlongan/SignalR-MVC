using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalRInterface;
using SignalRModel;

namespace SignalRDAL
{
    public class ChatDAL : IDataAccessLayer<Chat>
    {
        private readonly IRepository _repository;
        public ChatDAL(IRepository repository)
        {
            _repository = repository;
        }
        public List<Chat> Get()
        {
            return _repository.Chats.ToList();
        }
        public bool Save(Chat chat)
        {
            _repository.Chats.Add(chat);

            return _repository.SaveChanges() > 0;
        }
    }
}
