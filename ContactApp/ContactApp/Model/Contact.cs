﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp.Model
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string AditionalInfo { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
    }
}
