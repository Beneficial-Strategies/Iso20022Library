// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ATMSignature2Choice
{
    /// <summary>
    /// The data block for a TR31 or TR34 block, where the block does not contain a key (for example the TR34 unbind which contains the signed authorization data).
    /// </summary>
    [IsoId("_iFHDY7TwEeeQy4o2AayYHg")]
    [DisplayName("TR Related Data")]
    public partial record TRRelatedData : ATMSignature2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specific TR34 command where the TRBlock is a TR34 block.
        /// </summary>
        [IsoId("_PZ0GEbTpEeeQy4o2AayYHg")]
        [DisplayName("TR 34 Command")]
        [IsoXmlTag("TR34Cmd")]
        public TR34Command1Code? TR34Command { get; init; } 
        
        /// <summary>
        /// TR31 or TR34 data block.
        /// </summary>
        [IsoId("_PZ0GE7TpEeeQy4o2AayYHg")]
        [DisplayName("TR Block")]
        [IsoXmlTag("TRBlck")]
        [IsoSimpleType(IsoSimpleType.Max100KBinary)]
        public IsoMax100KBinary? TRBlock { get; init; } 
        
        
        #nullable disable
        
    }
}
