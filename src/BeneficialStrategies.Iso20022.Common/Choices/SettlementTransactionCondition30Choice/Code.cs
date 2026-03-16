// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition30Choice
{
    /// <summary>
    /// Settlement condition expressed as a code.
    /// </summary>
    [IsoId("_1wpf00c8EeaBWtcfqEyXyw")]
    [DisplayName("Code")]
    public record Code : SettlementTransactionCondition30Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions under which a order/trade is to be settled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementTransactionCondition11Code Value { get; init; }
    }
}
