// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus25Choice
{
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [IsoId("_8QcPs5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SettlementStatus25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status of settlement of an instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesSettlementStatus2Code Value { get; init; }
    }
}
