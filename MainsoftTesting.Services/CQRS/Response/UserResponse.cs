namespace MainsoftTesting.Services.CQRS.Response
{
    public class CreateUserResponse
    {
        public string Error { get; set; }
        public string Message { get; set; }
        public string UserID { get; set; }
        public string UserToken { get; set; }

    }
}
