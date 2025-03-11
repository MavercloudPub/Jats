using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.PubMedEntities{ 

[XmlRoot(ElementName="MeshHeadingList")]
public class MeshHeadingList { 

	[XmlElement(ElementName="MeshHeading")] 
	public List<MeshHeading> MeshHeading { get; set; } 
}

}