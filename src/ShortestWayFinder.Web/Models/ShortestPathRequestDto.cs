﻿using System.ComponentModel.DataAnnotations;
using ShortestWayFinder.Web.ValidationAttributes;

namespace ShortestWayFinder.Web.Models
{
    public class ShortestPathRequestDto
    {
        [Required]
        public string FirstPoint { get; set; }
        [Required]
        [PointsNameNotEqual("FirstPoint", ErrorMessage = "Second point can not be first point!")]
        public string SecondPoint { get; set; }
    }
}
