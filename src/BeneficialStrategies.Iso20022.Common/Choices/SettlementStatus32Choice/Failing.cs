// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus32Choice
{
    /// <summary>
    /// Failing.
    /// </summary>
    [DisplayName("Failing")]
    public record Failing : SettlementStatus32Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Flng")]
        public required FailingStatus15Choice_ Value { get; init; }
    }
}
