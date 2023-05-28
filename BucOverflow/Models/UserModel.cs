using System.ComponentModel.DataAnnotations;
namespace BucOverflow.Models
/*
 * This is the Model for the User objects in the Users database. Username can be nullable here, because we mainly want
 * to verify by email. Password is non-nullable for obvious reasons.
 */
{
	public class UserModel
	{
		[Key]
		public int UserID { get; set; }
		public string Email { get; set; }
		public string? Username { get; set; }
		public string? Token { get; set; }
		public int Verified { get; set; }
	}
}