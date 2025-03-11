using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="Frequency")]
public class Frequency { 

	[XmlAttribute(AttributeName="FrequencyType")] 
	public string FrequencyType { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

}