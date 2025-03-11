using System.Xml.Serialization; 
using System.Collections.Generic;
using Mavercloud.JATS.Entities;

namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "GrantList")]
	public class GrantList
	{

		[XmlElement(ElementName = "Grant")]
		public List<Grant> Grant { get; set; }

		[XmlAttribute(AttributeName = "CompleteYN")]
		public string CompleteYN { get; set; }


	}

}