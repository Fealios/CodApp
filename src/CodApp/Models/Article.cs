﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodApp.Models
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageSrcString { get; set; }
        public string PageLabel { get; set; }
        public virtual Newsletter Newsletter { get; set; }
    }
}
