// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition8Choice
{
    /// <summary>
    /// Trade condition expressed as a code.
    /// </summary>
    [IsoId("_P2iDk0c9EeaBWtcfqEyXyw")]
    [DisplayName("Code")]
    public record Code : TradeTransactionCondition8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions under which the order/trade is to be/was executed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeTransactionCondition5Code Value { get; init; }
    }
}
