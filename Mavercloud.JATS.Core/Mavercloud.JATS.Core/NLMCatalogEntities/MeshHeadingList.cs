using System.Xml.Serialization; 
using System.Collections.Generic;
namespace Mavercloud.JATS.NLMCatalogEntities
{

	[XmlRoot(ElementName = "MeshHeadingList")]
	public class MeshHeadingList
	{

		[XmlElement(ElementName = "MeshHeading")]
		public List<MeshHeading> MeshHeading { get; set; }
	}

}