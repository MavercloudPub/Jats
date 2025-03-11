using System.Xml.Serialization; 
using System.Collections.Generic; 
namespace Mavercloud.JATS.PubMedEntities{ 

[XmlRoot(ElementName="ArticleIdList")]
public class ArticleIdList { 

	[XmlElement(ElementName="ArticleId")] 
	public List<ArticleId> ArticleId { get; set; } 
}

}