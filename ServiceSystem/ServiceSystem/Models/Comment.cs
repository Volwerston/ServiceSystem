﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceSystem.Models
{
    public class CommentParams
    { 
        public int Mark { get; set; }
        public string Comment { get; set; }
        public int ApplicationId { get; set; }
    }
}