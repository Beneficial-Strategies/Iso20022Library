// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionType6Choice
{
    /// <summary>
    /// Option type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_uAXhoznCEeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public record Code : OptionType6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionType1Code Value { get; init; }
    }
}
