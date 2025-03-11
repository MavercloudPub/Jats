using Mavercloud.JATS.Entities;
using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "QualifierName")]
	public class QualifierName : InnerXmlElement
	{

		[XmlAttribute(AttributeName = "UI")]
		public string UI { get; set; }

		[XmlAttribute(AttributeName = "MajorTopicYN")]
		public string MajorTopicYN { get; set; }

	}

}