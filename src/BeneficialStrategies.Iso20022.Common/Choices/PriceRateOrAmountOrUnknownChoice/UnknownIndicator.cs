// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknownChoice
{
    /// <summary>
    /// Indicates whether the market price is unknown.
    /// </summary>
    [IsoId("_QaaCF9p-Ed-ak6NoX_4Aeg_-1972249999")]
    [DisplayName("Unknown Indicator")]
    public record UnknownIndicator : PriceRateOrAmountOrUnknownChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("UknwnInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
