using System;
namespace CornerShop.Model.Entities
{
	[Table("Product")]
	public class Product
	{

		[Key]

		public int Id { get; set; }

		[Required]
		public String Name { get; set; }


		public Product()
		{
		}
	}
}

