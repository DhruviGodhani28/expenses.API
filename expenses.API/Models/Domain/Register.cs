using Microsoft.EntityFrameworkCore;

namespace expenses.API.Models.Domain
{
    public class Register
    {
        public required string UserId { get; set; }

        public required string CreatePassword { get; set; }
        public required string ConfirmPassword { get; set; }

    }
}
