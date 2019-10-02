using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
	public class Course
	{
		[Display(Name="Course ID")]
		public virtual int CourseId { get; set; }
		[Display(Name = "Course Title")]
		[Required]
		[StringLength(150)]
		public virtual string CourseTitle { get; set; }
		[Display(Name = "Description")]
		public virtual string CourseDesc { get; set; }
		[Display(Name = "Number of Credits")]
		[Required]
		[Range(1, 4)]
		public virtual int CourseCredits { get; set; }
	}
}