// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat57Choice
{
    /// <summary>
    /// Not Specified Rate.
    /// </summary>
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RateAndAmountFormat57Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateValueType7Code Value { get; init; }
    }
}
