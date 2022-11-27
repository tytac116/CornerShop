using System;
namespace CornerShop.Model.Entities
{
	[Table("Products")]
	public class Products
	{

		[Key]

		public int Id { get; set; }

		[Required]
		public String Name { get; set; }


		public Products()
		{
		}
	}
}

