using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressPCL.Models;

namespace Axon.me.ViewModels
{
    public class PostViewModel
    {
      
        public string Template { get; set; }
        public int[] Tags { get; set; }
        public int[] Categories { get; set; }
        public string Format { get; set; }
        public int Author { get; set; }
        public string Link { get; set; }
        public Title Title { get; set; }
        public string Type { get; set; }
        public Status Status { get; set; }
        public string Slug { get; set; }
        public string Password { get; set; }
        public DateTime Modified { get; set; }
        public DateTime DateGmt { get; set; }
        public DateTime Date { get; set; }
        public Content Content { get; set; }
        public Embedded Embedded { get; set; }
        public static implicit operator PostViewModel(WordPressPCL.Models.Post model)
        {
            return new PostViewModel()
            {
                Template = model.Template,
                Tags = model.Tags,
                Categories = model.Categories,
                Format = model.Format,
                Author = model.Author,
                Link = model.Link,
                Title = model.Title,
                Type = model.Type,
                Status = model.Status,
                Slug = model.Slug,
                Password = model.Password,
                Modified = model.Modified,
                DateGmt = model.DateGmt,
                Date = model.Date,
                Content = model.Content,
                Embedded = model.Embedded,
            };
        }
    }
}
