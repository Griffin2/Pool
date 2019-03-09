using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Poolearn.Models
{
    public enum WinnerRule
    {
        [Description("Top Winner Takes The Pool")]
        TAKEALL,
        [Description("Top 2 Winners Take The Pool")]
        TOPTWO,
        [Description("Top 3 Winners Take The Pool")]
        TOPTHREE
    }

    public class ThreadViewModel
    {
        public int Id { get; set; }
        public string Message { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Creator")]
        public string Email { get; set; }

        public List<string> Users { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate{ get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public bool ReOccurring { get; set; }
        public int Frequency { get; set; }

        [Description("In The Case of a Tie, the Pool Will Collect Another Round Until A Winner is Found")]
        [Display(Name = "Sudden Death?")]
        public bool RollOver { get; set; } = true;

        [Required]
        [Display(Name = "Wage Amount")]
        public decimal AmountDue { get; set; }

        [Display(Name = "User Cap")]
        [Description("Amount Of Users Allowed")]
        public int MaxUsers { get; set; }

        [Required]
        [Display(Name = "Winner Wins By")]
        public WinnerRule RuleType { get; set; }
    }
}
