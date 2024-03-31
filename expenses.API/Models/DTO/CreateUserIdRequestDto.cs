namespace expenses.API.Models.DTO
{
    public class CreateUserIdRequestDto
    {
        public required string UserId { get; set; }

        public required string CreatePassword { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
