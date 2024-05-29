﻿namespace OnlineEdu.Entity.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; }
        public CourseCategory Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShow { get; set; }
    }
}
