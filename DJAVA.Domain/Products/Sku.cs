namespace DJAVA.Domain.Products
{
	public record Sku
	{
		private const int DefaultLenght = 15;
		private Sku(string value) => value = value.Trim();

		public string Value { get; init; }

		public static Sku? Create(string value)
		{
			if (string.IsNullOrEmpty(value)) return null;

			if(value.Length != DefaultLenght) return null;

			return new Sku(value);
		}

	}
}
