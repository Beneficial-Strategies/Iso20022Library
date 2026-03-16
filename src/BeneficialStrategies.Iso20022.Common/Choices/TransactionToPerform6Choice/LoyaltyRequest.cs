// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform6Choice
{
    /// <summary>
    /// Loyalty Request.
    /// </summary>
    [DisplayName("Loyalty Request")]
    public record LoyaltyRequest : TransactionToPerform6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("LltyReq")]
        public required LoyaltyRequest6 Value { get; init; }
    }
}
