using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiBusinessLogic.Interfaces.General;
using ApiModel.RequestDTO.Login;
using ApiModel.ResponseDTO.Login;
using ApiModel.User;
using ApiUnitOfWork.General;
using Microsoft.IdentityModel.Tokens;

namespace ApiBusinessLogic.Implementation.General
{
    public class LoginLogic : ILoginLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public LoginResponse Login(LoginRequest dto)
        {
            try
            {
                LoginResponse response = new LoginResponse();
                var validateUser = _unitOfWork.IUser.ValidateUsername(dto.username);

                if(validateUser != null)
                {
                    if(validateUser.password == dto.password)
                    {
                        var secretKey = "ga7586mag07g11a9a8g1m6y0s6s9l9c";
                        var key = Encoding.ASCII.GetBytes(secretKey);

                        var claims = new ClaimsIdentity();
                        claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, dto.username));

                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = claims,
                            Expires = DateTime.UtcNow.AddHours(4),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var createdToken = tokenHandler.CreateToken(tokenDescriptor);

                        string bearer_token = tokenHandler.WriteToken(createdToken);

                        response.fullName = validateUser.fullName;
                        response.Token = bearer_token;
                    }
                    else
                    {
                        throw new UnauthorizedAccessException("unAuthorized");
                    }
                }
                else
                {
                    throw new UnauthorizedAccessException("unAuthorized");
                }
                return response;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
