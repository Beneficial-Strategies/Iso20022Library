// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice
{
    /// <summary>
    /// Indicates if the goods have passed the health check.
    /// </summary>
    [IsoId("_3DBVOzANEeOKib24wnHaFg")]
    [DisplayName("Health Indication")]
    public record HealthIndication : CertifiedCharacteristics2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("HlthIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
