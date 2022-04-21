using System;
using System.Collections.Generic;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Persistence.Models;
using User = MainsoftTesting.Services.Domain.Entities.User;
using AutoMapper;

namespace MainsoftTesting.Services.Persistence
{
    public class UserOperations
    {
        public static bool AddUser(User user)
        {
            try
            {
                using(TestingContext context = new TestingContext())
                {
                    Mapper.CreateMap<User, MainsoftTesting.Services.Persistence.Models.User>();
                    var obj = Mapper.Map<MainsoftTesting.Services.Persistence.Models.User>(user);
                    context.Add(obj); 
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<User> ListUsers()
        {
            List<User> result = new List<User>();

            try
            {
                using (TestingContext context = new TestingContext())
                {
                    var list = context.Users.ToList();
                    foreach (MainsoftTesting.Services.Persistence.Models.User user in list)
                    {
                        Mapper.CreateMap<MainsoftTesting.Services.Persistence.Models.User, User>();
                        var obj = Mapper.Map<User>(user);
                        result.Add(obj);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                result = null;
                return result;
            }
        }

    }
}