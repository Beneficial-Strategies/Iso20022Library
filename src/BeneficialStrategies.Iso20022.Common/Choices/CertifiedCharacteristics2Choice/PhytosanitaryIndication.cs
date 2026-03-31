// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice
{
    /// <summary>
    /// Indicates if the goods have passed the phytosanitary check.
    /// </summary>
    [IsoId("_3DBVPTANEeOKib24wnHaFg")]
    [DisplayName("Phytosanitary Indication")]
    public record PhytosanitaryIndication : CertifiedCharacteristics2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("PhytosntryIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
