namespace RazorViewV1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RAZOR_PAGES
    {
        [Key]
        public Guid PageId { get; set; }

        public Guid ParentId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string ViewName { get; set; }

        public string ViewData { get; set; }

    }

}
