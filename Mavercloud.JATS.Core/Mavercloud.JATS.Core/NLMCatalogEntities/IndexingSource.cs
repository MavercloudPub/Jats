using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="IndexingSource")]
public class IndexingSource { 

	[XmlElement(ElementName="IndexingSourceName")] 
	public IndexingSourceName IndexingSourceName { get; set; } 

	[XmlElement(ElementName="Coverage")] 
	public string Coverage { get; set; } 
}

}