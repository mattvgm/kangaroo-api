namespace kangaroo_api.Domains.Users.dtos;

public class UserLoginDTO
{
    public string email { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
}