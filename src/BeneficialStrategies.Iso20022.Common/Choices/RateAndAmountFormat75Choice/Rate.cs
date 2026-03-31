// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat75Choice
{
    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    public record Rate : RateAndAmountFormat75Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rate")]
        public required IsoPercentage14Rate Value { get; init; }
    }
}
