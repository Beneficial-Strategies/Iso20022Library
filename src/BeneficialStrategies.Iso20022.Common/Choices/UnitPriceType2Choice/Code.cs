// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnitPriceType2Choice
{
    /// <summary>
    ///  Type of price expressed as a code.
    /// </summary>
    [IsoId("_ORWfkQc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Code")]
    public record Code : UnitPriceType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice10Code Value { get; init; }
    }
}
