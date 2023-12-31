﻿using System;
using System.Collections;
using System.Linq;
using Entites;

namespace NetCoreWebApplication.Models
{
    public class HomePageViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<News> News { get; set; }
        public List<Post> Posts { get; set; }
    }
}
