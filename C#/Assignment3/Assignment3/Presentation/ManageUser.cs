using System;
using TodoApp.DataModel;
using TodoApp.Repositories;
using TodoApp.Repositories.Interfaces;

namespace TodoApp.Presentation
{
	public class ManageUser
	{
        private IReference<UserClass> _userRepository = new UserClassRepositories();


        private void Add()
        {
            UserClass u = new UserClass();

            Console.WriteLine("Enter User ID: ");
            u.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter User Name: ");
            u.Name = Console.ReadLine();

            Console.WriteLine("Enter User Password: ");
            u.Password = Console.ReadLine();

            int success = _userRepository.Insert(u);
            if(success == 1)
            {
                Console.WriteLine("USer Created Successfuly");
            }
            else
            {
                Console.WriteLine("User Already Exist!");
            }

        }
    }
}

