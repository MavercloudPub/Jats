using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="Resource")]
public class Resource { 

	[XmlElement(ElementName="ContentType")] 
	public string ContentType { get; set; } 

	[XmlElement(ElementName="MediaType")] 
	public string MediaType { get; set; } 

	[XmlElement(ElementName="CarrierType")] 
	public string CarrierType { get; set; } 
}

}