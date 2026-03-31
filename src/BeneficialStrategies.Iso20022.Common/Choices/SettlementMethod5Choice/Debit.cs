// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod5Choice
{
    /// <summary>
    /// Debit.
    /// </summary>
    [DisplayName("Debit")]
    public record Debit : SettlementMethod5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Dbt")]
        public required CreditTransferTransaction59 Value { get; init; }
    }
}
