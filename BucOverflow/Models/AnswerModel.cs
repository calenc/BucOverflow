using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BucOverflow.Models
{
    public class AnswerModel
    {
        [Key]
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        [ForeignKey("QuestionID")]
        public QuestionModel QuestionModel { get; set; }
        public string? AnswerText { get; set; }
    }
}