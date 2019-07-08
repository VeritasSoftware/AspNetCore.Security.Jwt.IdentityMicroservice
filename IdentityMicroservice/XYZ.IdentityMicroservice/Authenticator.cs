using AspNetCore.Security.Jwt;
using System.Threading.Tasks;

namespace XYZ.IdentityMicroservice
{
    public class Authenticator : IAuthentication
    {
        public async Task<bool> IsValidUser(string id, string pwd) => await Task.FromResult(true);
    }
}
