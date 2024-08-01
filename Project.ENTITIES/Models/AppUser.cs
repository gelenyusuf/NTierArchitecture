using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
	public class AppUser:BaseEntity
	{
		public string  UserName { get; set; }

		public string  Password { get; set; }

		//Relational Properties

		public virtual AppUserProfile Profile { get; set; }
	}
}
