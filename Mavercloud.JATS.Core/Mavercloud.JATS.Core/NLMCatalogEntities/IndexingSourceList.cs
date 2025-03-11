using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="IndexingSourceList")]
public class IndexingSourceList { 

	[XmlElement(ElementName="IndexingSource")] 
	public List<IndexingSource> IndexingSource { get; set; } 
}

}