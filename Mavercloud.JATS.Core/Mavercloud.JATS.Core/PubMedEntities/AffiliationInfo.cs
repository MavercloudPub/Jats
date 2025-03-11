using System.Collections.Generic;
using System.Xml.Serialization;
namespace Mavercloud.JATS.PubMedEntities
{

	[XmlRoot(ElementName = "AffiliationInfo")]
	public class AffiliationInfo
	{

		[XmlElement(ElementName = "Affiliation")]
		public string Affiliation { get; set; }
	}

}