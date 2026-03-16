// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition6Choice
{
    /// <summary>
    /// Settlement conditions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_3LNsn-EAEd-udr336SN7mQ")]
    [DisplayName("Code")]
    public record Code : SettlementTransactionCondition6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions under which the order/trade is to be settled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementTransactionCondition6Code Value { get; init; }
    }
}
