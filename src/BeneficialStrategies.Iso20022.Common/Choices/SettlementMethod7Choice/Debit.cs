// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod7Choice
{
    /// <summary>Settlement via a debit transfer transaction.</summary>
    [IsoId("_GcCY03eKEfCdoODv2ypKfw")]
    [DisplayName("Debit")]
    public record Debit : SettlementMethod7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Dbt")]
        public required CreditTransferTransaction78 Value { get; init; }
    }
}
