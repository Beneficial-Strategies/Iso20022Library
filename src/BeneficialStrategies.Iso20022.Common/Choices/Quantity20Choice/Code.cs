// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity20Choice
{
    /// <summary>
    /// Standard code to specify quantity of a financial instrument.
    /// </summary>
    [IsoId("_BX0hQ0GUEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : Quantity20Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies quantity of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Quantity1Code Value { get; init; }
    }
}
