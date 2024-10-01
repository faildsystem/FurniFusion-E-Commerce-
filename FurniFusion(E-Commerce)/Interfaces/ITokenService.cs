using FurniFusion_E_Commerce_.Models;

namespace FurniFusion_E_Commerce_
{
    public interface ITokenService
    {
        string CreateToken(User appUser);
    }
}
