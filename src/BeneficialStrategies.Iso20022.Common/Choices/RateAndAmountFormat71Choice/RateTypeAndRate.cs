// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat71Choice
{
    /// <summary>
    /// Rate Type And Rate.
    /// </summary>
    [DisplayName("Rate Type And Rate")]
    public record RateTypeAndRate : RateAndAmountFormat71Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RateTpAndRate")]
        public required RateTypeAndPercentageRate19 Value { get; init; }
    }
}
