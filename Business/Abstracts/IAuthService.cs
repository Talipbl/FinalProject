using Core.Entities.Concretes;
using Core.Security.JWT;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes.DTOs;

namespace Business.Abstracts
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
