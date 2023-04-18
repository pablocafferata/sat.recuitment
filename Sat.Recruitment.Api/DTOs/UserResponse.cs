using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.DTOs
{
    public class UserResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
