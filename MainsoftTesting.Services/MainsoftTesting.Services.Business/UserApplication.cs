using System;
using System.Collections.Generic;
using MainsoftTesting.Services.Domain.Entities;
using MainsoftTesting.Services.Persistence;
using MainsoftTesting.Services.Domain.CQRS.Response;

namespace MainsoftTesting.Services.Application
{
    public class UserApplication
    {
        public static AddUserResponse AddUser(User user)
        {
            AddUserResponse response = new AddUserResponse();

            try
            {
                bool result = UserOperations.AddUser(user);
                if (result)
                {
                    response.Success = true;
                    response.Message = "OK";
                    response.Error = "";
                    return response;
                }

                throw new Exception("Error saving record");
                   
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Error = "Fail";
                return response;
            }
        }

        public static ListUsersResponse ListUsers()
        {
            ListUsersResponse response = new ListUsersResponse();

            try 
            {
                List<User> users = UserOperations.ListUsers();
                if(users != null)
                {
                    response.Success = true;
                    response.Message = "OK";
                    response.Error = "";
                    response.Users = users;
                    return response;
                }

                throw new Exception("Error retrieving records");

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.Error = "Fail";
                response.Users = null;
                return response;

            }
        }
    }
}