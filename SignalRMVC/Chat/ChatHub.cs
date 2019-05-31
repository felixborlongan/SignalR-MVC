using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRInterface;
using Unity.Attributes;
using SignalRModel;

namespace SignalRMVC
{ 
    public class ChatHub : Hub
    {
        private readonly IDataAccessLayer<User> _uDAL;
        private readonly IDataAccessLayer<Chat> _cDAL;
        public ChatHub(IDataAccessLayer<User> uDAL, IDataAccessLayer<Chat> cDAL)
        {
            _uDAL = uDAL;
            _cDAL = cDAL;
        }
        public void Send(string name, string message)
        {
            //Clients.All.hello();
            Clients.All.addNewMessageToPage(name, message);

            User userToBeAdded = new User()
            {
                Name = name
            };

            if (_uDAL.Save(userToBeAdded))
            {
                _cDAL.Save(new Chat()
                {
                    UserID = userToBeAdded.UserID,
                    Message = message
                });
            }
        }
    }
}