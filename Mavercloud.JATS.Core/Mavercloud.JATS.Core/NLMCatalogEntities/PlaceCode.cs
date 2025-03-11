using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="PlaceCode")]
public class PlaceCode { 

	[XmlAttribute(AttributeName="Authority")] 
	public string Authority { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}