// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMSignature2Choice
{
    /// <summary>
    /// Digital signature of implicit data depending on the security scheme download procedure.
    /// </summary>
    [IsoId("_iFHDYbTwEeeQy4o2AayYHg")]
    [DisplayName("Digital Signature")]
    public record DigitalSignature : ATMSignature2Choice_
    {
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
    }
}
