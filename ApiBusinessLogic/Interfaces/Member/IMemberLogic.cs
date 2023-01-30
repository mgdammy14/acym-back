using System;
using System.Collections.Generic;
using ApiModel.Member;
using ApiModel.RequestDTO.Member;

namespace ApiBusinessLogic.Interfaces.Member
{
    public interface IMemberLogic
    {
        public List<Members> GetMembers();
        public int CreateMember(MemberRequest dto);
        public bool UpdateMember(Members dto);
    }
}
