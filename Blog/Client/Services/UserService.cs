using Blog.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Net.Http;

namespace Blog.Client.Services
{
    public class UserService
    {
        [Inject]
        protected HttpClient _httpClient { get; set; }

        public UserModel UserModel { get; set; }
        public List<UserModel> UserModels { get; set; }

        private bool IsLoggedIn { get; set; }

        public async Task<bool> LoginUser(string username, string password)
        {
            UserModels = await _httpClient.GetFromJsonAsync<List<UserModel>>("/api/usermodels");
            UserModel = UserModels.FirstOrDefault(i => i.Username.Equals(username) && i.Password.Equals(password));

            if (UserModel != null)
            {
                IsLoggedIn = true;
            }
            else
            {
                IsLoggedIn = false;
            }

            return IsLoggedIn;
        }

        public bool GetLoginStatus()
        {
            return IsLoggedIn;
        }
    }
}
