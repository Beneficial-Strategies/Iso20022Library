// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCodeChoice
{
    /// <summary>
    /// Frequency expressed as a code.
    /// </summary>
    [IsoId("_Uuhiodp-Ed-ak6NoX_4Aeg_501343039")]
    [DisplayName("Frequency As Code")]
    public record FrequencyAsCode : FrequencyCodeAndDSSCodeChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("FrqcyAsCd")]
        public required Frequency1Code Value { get; init; }
    }
}
