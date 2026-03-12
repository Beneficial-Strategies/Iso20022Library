// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ATMSignature2Choice
{
    /// <summary>
    /// Digital signature of implicit data depending on the security scheme download procedure.
    /// </summary>
    [IsoId("_iFHDYbTwEeeQy4o2AayYHg")]
    [DisplayName("Digital Signature")]
    public partial record DigitalSignature : ATMSignature2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_NjOT0YtNEeSxlKlAGYErFg")]
        [DisplayName("Content Type")]
        [IsoXmlTag("CnttTp")]
        public required ContentType2Code ContentType { get; init; } 
        
        /// <summary>
        /// Data protected by a digital signatures.
        /// </summary>
        [IsoId("_NjOT14tNEeSxlKlAGYErFg")]
        [DisplayName("Signed Data")]
        [IsoXmlTag("SgndData")]
        public required SignedData4 SignedData { get; init; } 
        
        
        #nullable disable
        
    }
}
