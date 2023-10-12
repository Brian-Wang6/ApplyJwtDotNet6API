using TasksApi.Entities;
using TasksApi.Requests;
using TasksApi.Responses;

namespace TasksApi.Interfaces
{
    public interface ITokenService
    {
        Task<Tuple<string, string>> GenerateTokenAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(User user);
    }
}
