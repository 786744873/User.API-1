﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models
{
    public class AppSettings
    {
        public string MongoConnectionString { get; set; }

        public string MongoContactDatabase { get; set; }
    }
}
