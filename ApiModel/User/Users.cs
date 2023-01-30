using System;
using ApiModel.RequestDTO.User;
using Dapper.Contrib.Extensions;

namespace ApiModel.User
{
    public class Users
    {
        [Key]
        public int idUser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }

        public Users Mapper(Users obj, UserRequest dto)
        {
            obj.username = dto.username;
            obj.password = dto.password;
            obj.fullName = dto.fullName;
            return obj;
        }
    }
}
