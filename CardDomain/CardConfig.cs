using CardDomain.Interfaces;

namespace CardDomain
{
	public class CardConfig : ICardConfig
	{
		public string Url { get ; set; }
		public string Token { get; set ; }
	}
}
