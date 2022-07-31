using System.Threading.Tasks;
using CompanyAPI.Core.Entities;
using JWTProject.Core.Dto;

namespace JWTProject.Core
{
    public interface IAuthenticationService
    {
        Task<ResponseEntity> CreateTokenAsync(LoginRequest login); //TokenDto döneceğim.
        Task<ResponseEntity> CreateTokenByRefreshTokenAsync(string refreshToken); //Refresh Token ile Access Token oluşturma.
        Task<ResponseEntity> RevokeRefreshTokenAsync(string refreshToken); //Token'ın kötü kullanılmasına ilişkin token'ı sonlandırma
    }
}
