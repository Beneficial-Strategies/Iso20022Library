// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknown1Choice
{
    /// <summary>
    /// Indicates whether the market price is unknown.
    /// </summary>
    [IsoId("_Wi6RYdp-Ed-ak6NoX_4Aeg_-1982209591")]
    [DisplayName("Unknown Indicator")]
    public record UnknownIndicator : PriceRateOrAmountOrUnknown1Choice_
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
