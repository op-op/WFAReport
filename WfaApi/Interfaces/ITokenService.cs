using WfaApi.Entities;

namespace WfaApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}