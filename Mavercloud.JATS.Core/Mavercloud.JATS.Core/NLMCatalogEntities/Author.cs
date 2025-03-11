using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="Author")]
public class Author { 

	[XmlElement(ElementName="CollectiveName")] 
	public string CollectiveName { get; set; } 

	[XmlElement(ElementName="Identifier")] 
	public List<Identifier> Identifier { get; set; } 
}

}