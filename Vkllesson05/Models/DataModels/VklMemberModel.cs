﻿using Microsoft.AspNetCore.Mvc;

namespace Vkllesson05.Models.DataModels
{
    public class MemberModel
    {
        public string MemberId { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
