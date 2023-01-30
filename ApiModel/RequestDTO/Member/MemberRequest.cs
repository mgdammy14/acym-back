using System;
namespace ApiModel.RequestDTO.Member
{
    public class MemberRequest
    {
        public string documentNumber { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
