using System.ComponentModel.DataAnnotations;
namespace BucOverflow.Models
{
	public class QuestionModel
	{
		[Key]
		public int QuestionID { get; set; }
		public string? Title { get; set; }
		public string? UserText { get; set; }
		public string? Tag { get; set; }
		public string DateAsked { get; set; }
	}
}