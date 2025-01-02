namespace JWTImplementation.Request_Models
{
    public class LoginRequest
    {
        public string Username {  get; set; }
        public required string Password { get; set; }

    }
}
