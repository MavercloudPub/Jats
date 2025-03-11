using System.Xml.Serialization; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="PhysicalDescription")]
public class PhysicalDescription { 

	[XmlElement(ElementName="Extent")] 
	public string Extent { get; set; } 
}

}