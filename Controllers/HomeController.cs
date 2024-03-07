using FAQs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FAQs.Controllers
{
    public class HomeController : Controller
    {
        private FAQsContext context {  get; set; }

        public HomeController(FAQsContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string topic, string category)
        {
            // ALL FAQS
            var faqs = context.FAQs.Include(f => f.Category).Include(f => f.Topic).OrderBy(f => f.Question).ToList();

            // Topics
            ViewBag.Topics = context.Topics.OrderBy(t => t.Name).ToList();
            ViewBag.SelectedTopic = topic;

            // Categories
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();

            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(f => f.Topic.TopicId == topic).ToList();
            }
            if(!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(f => f.Category.CategoryId == category).ToList();
            }
            
            return View(faqs);
        }

    }
}
