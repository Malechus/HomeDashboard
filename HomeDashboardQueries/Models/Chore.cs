using System;
using System.Collections.Generic;

namespace HomeDashboardQueries.Models
{
    public partial class Chore
    {
        public int Id { get; set; }
        public string Chore1 { get; set; } = null!;
        public string? Monday { get; set; }
        public string? Tuesday { get; set; }
        public string? Wednesday { get; set; }
        public string? Thursday { get; set; }
        public string? Friday { get; set; }
        public string? Saturday { get; set; }
        public string? Sunday { get; set; }
        public TimeSpan? ChoreTime { get; set; }
    }
}
