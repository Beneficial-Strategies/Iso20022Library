// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementParties38Choice
{
    /// <summary>
    /// Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Delivering Settlement Parties")]
    public record DeliveringSettlementParties : SettlementParties38Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DlvrgSttlmPties")]
        public required DeliveringPartiesAndAccount22 Value { get; init; }
    }
}
