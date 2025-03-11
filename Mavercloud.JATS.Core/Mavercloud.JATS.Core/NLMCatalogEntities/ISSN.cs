using System.Xml.Serialization;
namespace Mavercloud.JATS.NLMCatalogEntities
{

	[XmlRoot(ElementName = "ISSN")]
	public class ISSN
	{

		[XmlAttribute(AttributeName = "IssnType")]
		//Print, Electronic
		public string IssnType { get; set; }

		[XmlText]
		public string Text { get; set; }

		[XmlAttribute(AttributeName = "ValidYN")]
		public string ValidYN { get; set; }
	}

}