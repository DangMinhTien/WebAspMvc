using Microsoft.AspNetCore.Authorization;

namespace Bai1_ChinhThuc.Security.Requirements
{
    public class CanEditContactRequirement : IAuthorizationRequirement
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public CanEditContactRequirement(int Year = 2023, int Month = 3, int Day = 10)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }
    }
}
