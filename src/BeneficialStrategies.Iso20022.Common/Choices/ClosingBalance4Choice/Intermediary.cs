// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance4Choice
{
    /// <summary>
    /// Closing balance of this page only. This balance must be the intermediary opening balance of the next page of the same statement.
    /// </summary>
    [IsoId("_Q8Um2TnGEeWV5sr121Fc8A")]
    [DisplayName("Intermediary")]
    public record Intermediary : ClosingBalance4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Intrmy")]
        public required BalanceQuantity8Choice_ Value { get; init; }
    }
}
