using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "DateCompleted")]
	public class DateCompleted
	{

		[XmlElement(ElementName = "Year")]
		public int? Year { get; set; }

		[XmlElement(ElementName = "Month")]
		public string Month { get; set; }

		[XmlElement(ElementName = "Day")]
		public int? Day { get; set; }
	}

}