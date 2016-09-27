﻿using System.Collections.Generic;

namespace Website.Models.ViewModels
{
    public class BlogViewModel
    {
        public List<Post> Posts { get; set; }
        public bool NextPage { get; set; }
        public bool PreviousPage { get; set; }
        public int TotalNumberPages { get; set; }
    }
}