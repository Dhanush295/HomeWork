using System;
using TodoApp.DataModel;
using TodoApp.Repositories.Interfaces;

namespace TodoApp.Repositories
{
    public class UserClassRepositories : IReference<UserClass>
    {
        private List<UserClass> _user = new List<UserClass>();

        public int Delete(int id)
        {
            UserClass u = GetById(id);
            if(u != null)
            {
                _user.Remove(u);
                return 1;
            }
            return 0;
        }

        public List<UserClass> GetAll()
        {
            return _user;
        }

        public UserClass GetById(int id)
        {
            for(int i=0; i<_user.Count; i++)
            {
                if (_user[i].Id == id)
                {
                    return _user[i];
                }
            }
            return null;
        }

        public int Insert(UserClass obj)
        {
          
            if (GetById(obj.Id) == null)
            {
                _user.Add(obj);
                return 1;
            }
            return 0;
        }

        public int Update(UserClass obj)
        {
            UserClass u = GetById(obj.Id);
            if(u != null)
            {
                u.Name = obj.Name;
                u.Password = obj.Password;
                return 1;
            }
            return 0;
        }
    }
}

