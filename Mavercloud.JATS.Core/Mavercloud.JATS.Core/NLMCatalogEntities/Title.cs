using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="Title")]
public class Title { 

	[XmlAttribute(AttributeName="Sort")] 
	public string Sort { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}