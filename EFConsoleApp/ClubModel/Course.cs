﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301ClubsV1.Models.ClubModel
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { set; get; }
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Display(Name = "Course Year")]
        public string Year { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
    }
}