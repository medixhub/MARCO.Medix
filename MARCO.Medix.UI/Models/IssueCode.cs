﻿using System.ComponentModel.DataAnnotations;

namespace MARCO.Medix.UI.Models
{
    public class IssueCode
    {
        [Key]
        public int Id { get; set; }
        public string StudyInstanceUID { get; set; }
        public string Code { get; set; }
    }
}
