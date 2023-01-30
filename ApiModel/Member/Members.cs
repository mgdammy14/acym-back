using System;
using ApiModel.RequestDTO.Member;
using Dapper.Contrib.Extensions;

namespace ApiModel.Member
{
    public class Members
    {
        [Key]
        public int idMember { get; set; }
        public string documentNumber { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int idState { get; set; }

        public Members Mapper(Members obj, MemberRequest dto)
        {
            obj.documentNumber = dto.documentNumber;
            obj.name = dto.name;
            obj.lastname = dto.lastname;
            obj.address = dto.address;
            obj.dateOfBirth = dto.dateOfBirth;
            obj.idState = 1;
            return obj;
        }
    }
}
