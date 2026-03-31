// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionStyle9Choice
{
    /// <summary>
    /// Option style expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_ctPX-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public record Code : OptionStyle9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Defines how an option can be exercised.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionStyle2Code Value { get; init; }
    }
}
