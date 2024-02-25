using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet7.ConsoleApp.Models
{
    [Table("Tbl_Blog")]
	public class  BlogModel
	{
        [Key]
		public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogContent { get; set; }

    }

    public class JsonPlaceHolderModel
    {
        public int userId { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }


}

