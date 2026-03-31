// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition6Choice
{
    /// <summary>
    /// Trade conditions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mslt5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : TradeTransactionCondition6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the conditions under which the order/trade is to be/was executed.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradeTransactionCondition4Code Value { get; init; }
    }
}
