using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
	public class Student : IValidatableObject
	{
		[Display(Name="Student ID")]
		public virtual int StudentId { get; set; }
		[Display(Name = "Last Name")]
		[Required]
		[StringLength(50)]
		public virtual string LastName { get; set; }
		[Display(Name = "First Name")]
		[Required]
		[StringLength(50)]
		public virtual string FirstName { get; set; }
		[Display(Name = "Address 1")]
		public virtual string Address1 { get; set; }
		[Display(Name = "Address 2")]
		public virtual string Address2 { get; set; }
		public virtual string City { get; set; }
		public virtual string Zipcode { get; set; }
		public virtual string State { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			var results = new List<ValidationResult>();
			Validator.TryValidateProperty(this.Address1,
				new ValidationContext(this, null, null) { MemberName = "Address1" },
				results);
			Validator.TryValidateProperty(this.Address2,
				new ValidationContext(this, null, null) { MemberName = "Address2" },
				results);
			Validator.TryValidateProperty(this.Zipcode,
				new ValidationContext(this, null, null) { MemberName = "Zipcode" },
				results);
			Validator.TryValidateProperty(this.State,
				new ValidationContext(this, null, null) { MemberName = "State" },
				results);

			if (Address1 == Address2)
			{
				yield return (new ValidationResult("Address2 cannot be the same as Address1"));
			}
			if (Zipcode.Length < 5 || Zipcode.Length > 5 )
			{
				yield return (new ValidationResult("Enter a 5 digit Zipcode"));
			}
			if (State.Length < 2 || State.Length > 2)
			{
				yield return (new ValidationResult("Enter a 2 digit State code"));
			} 
			
		}
	}
}