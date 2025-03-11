using System.Collections.Generic;
using System.Xml.Serialization;
namespace Mavercloud.JATS.NLMCatalogEntities
{

	[XmlRoot(ElementName = "NLMCatalogRecordSet")]
	public class NLMCatalogRecordSet
	{

		[XmlElement(ElementName = "NLMCatalogRecord")]
		public List<NLMCatalogRecord> NLMCatalogRecords { get; set; }
	}

}