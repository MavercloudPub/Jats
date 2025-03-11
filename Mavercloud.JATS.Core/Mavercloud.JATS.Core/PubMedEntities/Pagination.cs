using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "Pagination")]
	public class Pagination
	{

		[XmlElement(ElementName = "MedlinePgn")]
		public string MedlinePgn { get; set; }

		[XmlElement(ElementName = "StartPage")]
		public string StartPage { get; set; }

        [XmlElement(ElementName = "EndPage")]
        public string EndPage { get; set; }
    }

}