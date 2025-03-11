using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="IndexingSourceName")]
public class IndexingSourceName { 

	[XmlAttribute(AttributeName="IndexingTreatment")] 
	public string IndexingTreatment { get; set; } 

	[XmlAttribute(AttributeName="IndexingStatus")] 
	public string IndexingStatus { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}