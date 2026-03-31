// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginType2Choice
{
    /// <summary>
    /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
    /// </summary>
    [IsoId("_7-1ooI1rEeet3cKIYK84nw")]
    [DisplayName("Code")]
    public record Code : MarginType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginType2Code Value { get; init; }
    }
}
