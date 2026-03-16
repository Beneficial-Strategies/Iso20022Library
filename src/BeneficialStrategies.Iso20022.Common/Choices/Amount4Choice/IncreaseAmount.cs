// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Amount4Choice
{
    /// <summary>
    /// Increase Amount.
    /// </summary>
    [DisplayName("Increase Amount")]
    public record IncreaseAmount : Amount4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IncrAmt")]
        public required Amount2Choice_ Value { get; init; }
    }
}
