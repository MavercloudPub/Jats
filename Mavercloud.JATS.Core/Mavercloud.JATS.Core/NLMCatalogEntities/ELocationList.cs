using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.NLMCatalogEntities{ 

[XmlRoot(ElementName="ELocationList")]
public class ELocationList { 

	[XmlElement(ElementName="ELocation")] 
	public List<ELocation> ELocation { get; set; } 
}

}