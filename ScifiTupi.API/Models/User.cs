using System;
using System.Collections.Generic;

namespace ScifiTupi.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public int Block { get; set; }
        public int SendEmail { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public string Activation { get; set; }
        public DateTime? LastResetTime { get; set; }
        public int ResetCount { get; set; }
        public byte[] OtpKey { get; set; }
        public byte[] Otep { get; set; }
        public int RequireReset { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}