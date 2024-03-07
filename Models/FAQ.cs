using System.ComponentModel.DataAnnotations.Schema;

namespace FAQs.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

        [ForeignKey("Topic")]
        public string TopicId { get; set; } = string.Empty;
        public Topic Topic { get; set; } = null!;

        [ForeignKey("Category")]
        public string CategoryId { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;
    }
}
