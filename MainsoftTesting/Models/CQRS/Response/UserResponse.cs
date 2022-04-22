namespace MainsoftTesting.Models.CQRS.Response
{
    public class UserListResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public string? Message { get; set; }
        public List<Models.CreateUserViewModel>? Users { get; set; }

    }

    public class UserResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public string? Message { get; set; }

    }

    public class UserDetailResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public string? Message { get; set; }
        public Models.CreateUserViewModel? User { get; set; }

    }
}
