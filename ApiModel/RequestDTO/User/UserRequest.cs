using System;
namespace ApiModel.RequestDTO.User
{
    public class UserRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
    }
}
