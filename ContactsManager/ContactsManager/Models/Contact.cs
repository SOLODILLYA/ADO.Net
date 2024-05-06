﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Field { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
        public string Notes { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
    }
}
