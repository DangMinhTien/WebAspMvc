using Microsoft.AspNetCore.Authorization;

namespace Bai1_ChinhThuc.Security.Requirements
{
    public class GenZRequirement : IAuthorizationRequirement
    {
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public GenZRequirement(int fromYear = 1997, int toYear = 2012)
        {
            FromYear = fromYear;
            ToYear = toYear;
        }
    }
}
