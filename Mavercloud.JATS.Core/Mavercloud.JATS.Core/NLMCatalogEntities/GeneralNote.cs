using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="GeneralNote")]
public class GeneralNote { 

	[XmlAttribute(AttributeName="Owner")] 
	public string Owner { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}