using System;
namespace NewsWayra
{

	public enum Category
	{
		Business,
		Entertainment,
		Health,
		Politics,
		ScienceAndTechnology,
		Sports,
		UK,
		World,
		Unknown
	}


	public class New
	{
		public New(string name, string newUrl, string imageUrl, DateTime publishedDate, string category)
		{
			this.Name = name;
			this.NewUrl = newUrl;
			if (!string.IsNullOrEmpty(imageUrl))
			{
				ImageClient imageClient = new ImageClient();
				this.Image = imageClient.GetImage(imageUrl).Result; 
			}
			this.PublishedDate = publishedDate;
			if (!string.IsNullOrWhiteSpace(category))
			switch (category)
				{
					case "Business":
						this.category = Category.Business;
						break;
					case "Entertainment":
						this.category = Category.Entertainment;
						break;
					case "Health":
						this.category = Category.Health;
						break;
					case "ScienceAndTechnology":
						this.category = Category.ScienceAndTechnology;
						break;
					case "Politics":
						this.category = Category.Politics;
						break;
					case "Sports":
						this.category = Category.Sports;
						break;
					case "UK":
						this.category = Category.UK;
						break;
					case "World":
						this.category = Category.World;
						break;
					default:
						this.category = Category.Unknown;
						break;
				}
		}

		public string Name { get; set; }

		public string NewUrl { get; set; }

		public DateTime PublishedDate { get; set; }

		public byte[] Image { get; set; }

		public Category category { get; set; }


	}
}

