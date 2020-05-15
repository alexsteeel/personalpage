﻿using System.Collections.Generic;

namespace PersonalPage.Shared.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
