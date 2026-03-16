// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice
{
    /// <summary>
    /// Analysis of the goods, as proven by the certificate.
    /// </summary>
    [IsoId("_3DBVNTANEeOKib24wnHaFg")]
    [DisplayName("Analysis")]
    public record Analysis : CertifiedCharacteristics2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 70characters.
        /// </summary>
        [IsoXmlTag("Anlys")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public required IsoMax70Text Value { get; init; }
    }
}
