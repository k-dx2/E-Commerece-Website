﻿using System;
using System.Collections.Generic;
using System.Text;
using AmazonWeb.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AmazonWeb.Core.Entities
{
    public class Blog :Entity
    {
        [Required,StringLength(80)]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }


    }
}
