// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties37Choice
{
    /// <summary>
    /// Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Receiving Settlement Parties")]
    public record ReceivingSettlementParties : SettlementParties37Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RcvgSttlmPties")]
        public required ReceivingPartiesAndAccount21 Value { get; init; }
    }
}
