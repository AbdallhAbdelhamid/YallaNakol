﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YallaNakol.Data.Services
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
        public string SenderEmail { get; set; }
    }
}
