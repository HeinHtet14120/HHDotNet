using System;
namespace DotNet7.BirdWebApi.Models
{
	public class BirdDataModel
	{
		public int Id { get; set; }

		public string BirdMyanmarName { get; set; }

		public string BirdEnglishName { get; set; }

		public string Description { get; set; }

		public string ImagePath { get; set; } 
	}

    public class BirdViewModel
    {
        public int Bid { get; set; }

        public string BirdName { get; set; }

        public string BDes { get; set; }

        public string BirdImg { get; set; }
    }
}

