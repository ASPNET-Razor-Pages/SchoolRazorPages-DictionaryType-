using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SchoolRazorPages_DictionaryType_.Model;

namespace SchoolRazorPages_DictionaryType_.Pages
{
    public class IndexModel : PageModel
    {
        // This is binding property 
        public Dictionary<int, Student> DictStudent { get; set; }
        private readonly ILogger<IndexModel> _logger;
        // This line of code generate not duplicate values 
        private Random _ran = new Random(Guid.NewGuid().GetHashCode());
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;            
        }

        public void OnGet()
        {
            DictStudent = new Dictionary<int, Student>();
            DictStudent.Add(_ran.Next(1, 100), new Student { Id = 1, Name = "Alex", ImagePath = "/Images/alex.jpg" });
            DictStudent.Add(_ran.Next(1, 100), new Student { Id = 2, Name = "john", ImagePath = "/Images/john.jpg" });
            DictStudent.Add(_ran.Next(1, 100), new Student { Id = 3, Name = "nilma", ImagePath = "/Images/nilma.jpg" });
            DictStudent.Add(_ran.Next(1, 100), new Student { Id = 4, Name = "alex", ImagePath = "/Images/alex.jpg" });

        }
    }
}
