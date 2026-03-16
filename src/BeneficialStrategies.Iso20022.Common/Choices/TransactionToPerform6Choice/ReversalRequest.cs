// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform6Choice
{
    /// <summary>
    /// Reversal Request.
    /// </summary>
    [DisplayName("Reversal Request")]
    public record ReversalRequest : TransactionToPerform6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("RvslReq")]
        public required ReversalRequest6 Value { get; init; }
    }
}
