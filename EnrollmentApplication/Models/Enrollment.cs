using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
	public class Enrollment : DropCreateDatabaseAlways<EnrollmentDB>
	{
		public virtual int EnrollmentId { get; set; }
		public virtual int StudentId { get; set; }
		public virtual int CourseId { get; set; }
		[Required]
		[RegularExpression(@"[A-Fa-f]")]
		public virtual String Grade { get; set; }
		public virtual Student Student { get; set; }
		public virtual Course Course { get; set; }
		public virtual bool IsActive { get; set; }
		[Display(Name = "Assigned Campus")]
		[Required(ErrorMessage ="AssingedCampus Field Required")]
		public virtual String AssignedCampus { get; set; }
		[Display(Name ="Enrolled in Semester")]
		[Required]
		public virtual String EnrollmentSemester { get; set; }
		[Range(2018, 9999, ErrorMessage=" Enrollment Year must be after 2018")]
		[Required]
		public virtual int EnrollmentYear { get; set; }
		[InvalidChar("!@#$%^&*", ErrorMessage="Notes contains unacceptable characters!")]
		public virtual String Notes { get; set; }
		
		
	}
}