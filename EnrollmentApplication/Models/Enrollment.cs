using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
	public class Enrollment
	{
		public virtual int EnrollmentId { get; set; }
		public virtual int StudentId { get; set; }
		public virtual int CourseId { get; set; }
		public virtual int Grade { get; set; }
		public virtual Student Student { get; set; }
		public virtual Course Course { get; set; }
		public virtual bool IsActive { get; set; }
		public virtual String AssignedCampus { get; set; }
		public virtual String EnrollmentSemester { get; set; }
		public virtual int EnrollmentYear { get; set; }
	}
}