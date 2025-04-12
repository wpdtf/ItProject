using Azure.Core;
using ItProject.UI.StaticModel;
using System.Net.Http.Headers;

namespace ItProject.UI.Client;

public class SendToBack
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public SendToBack()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/Database/") };
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    public async Task AuthenticateAsync(AuthDTO request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));
        var response = await _httpClient.PostAsync("auth", content);

        if (response.IsSuccessStatusCode)
        {
            var responseJson = await response.Content.ReadAsStringAsync();

            var client = JsonSerializer.Deserialize<Auth>(responseJson, _jsonOptions);
            UpdateCurrentUser(client);
            return;
        }

        throw new Exception("Неверный логин или пароль");
    }

    public async Task RegisterAsync(Registration request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));
        var response = await _httpClient.PostAsync("registration", content);

        if (response.IsSuccessStatusCode)
        {
            return;
        }

        throw new Exception("Такая почта уже есть!");
    }

    private void UpdateCurrentUser(Auth user)
    {
        CurrentUser.Id = user.IdUser;
        CurrentUser.Position = user.Position;
    }

    public async Task CreateCodeAsync(string login)
    {
        var response = await _httpClient.PostAsync($"PasswordRecovery?address={login}", null);

        if (response.IsSuccessStatusCode)
        {
            return;
        }

        throw new Exception("Такого пользователя не существует!");
    }

    public async Task CheckCodeAsync(string login, int code)
    {
        var response = await _httpClient.GetAsync($"PasswordRecovery?address={login}&code={code}");

        if (response.IsSuccessStatusCode)
        {
            var responseJson = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(responseJson);
            bool isSuccess = doc.RootElement.GetProperty("isSuccess").GetBoolean();

            if (!isSuccess)
            {
                throw new Exception("Код введен некорректно!");
            }
        }
    }

    public async Task UpdatePasswordAsync(AuthDTO request)
    {
        var json = JsonSerializer.Serialize(request, _jsonOptions);
        var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));
        var response = await _httpClient.PutAsync("PasswordRecovery", content);

        if (response.IsSuccessStatusCode)
        {
            return;
        }

        throw new Exception("Что-то пошло не так!");
    }
}
