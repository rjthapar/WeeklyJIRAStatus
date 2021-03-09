using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeeklyJIRAStatus.Models
{
    public class WeeklyJIRA
    {
        public int Id { get; set; }        
        public string First_Name  { get; set; }
        [Required(ErrorMessage ="JIRA Number is required")]
        public string JIRA        { get; set; }
        public string Application { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "JIRA Status is required")]
        public string Status      { get; set; }
    }
}
