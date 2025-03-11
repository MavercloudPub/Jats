using Mavercloud.JATS.Entities;
using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "AbstractText")]
	public class AbstractText : InnerXmlElement
	{

		[XmlAttribute(AttributeName = "Label")]
		public string Label { get; set; }

		[XmlAttribute(AttributeName = "NlmCategory")]
		public string NlmCategory { get; set; }


	}

}