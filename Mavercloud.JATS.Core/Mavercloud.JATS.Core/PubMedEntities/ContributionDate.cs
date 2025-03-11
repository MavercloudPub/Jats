using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "ContributionDate")]
	public class ContributionDate
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public string Day { get; set; }
	}

}