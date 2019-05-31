using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalRInterface;
using SignalRModel;

namespace SignalRDAL
{
    public class UserDAL : IDataAccessLayer<User>
    {
        private readonly IRepository _repository;
        public UserDAL(IRepository repository)
        {
            _repository = repository;
        }
        public List<User> Get()
        {
            return _repository.Users.ToList();
        }
        public bool Save(User user)
        {
            bool isUserAdded = false;
            User duplicateUser = _repository.Users.FirstOrDefault(a => a.Name.Equals(user.Name));

            if (duplicateUser == null)
            {
                _repository.Users.Add(user);
                isUserAdded = _repository.SaveChanges() > 0;
            }

            return isUserAdded;
        }
    }
}
