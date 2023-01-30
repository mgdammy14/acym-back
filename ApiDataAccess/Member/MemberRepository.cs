using System;
using ApiDataAccess.General;
using ApiModel.Member;
using ApiRepositories.Member;

namespace ApiDataAccess.Member
{
    public class MemberRepository : Repository<Members> , IMemberRepository
    {
        public MemberRepository(string connectionsString) : base(connectionsString)
        {
        }
    }
}
