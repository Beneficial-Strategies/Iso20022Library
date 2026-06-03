// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystemPlace1Choice
{
    /// <summary>Place of safekeeping expressed with a Digital Ledger Identifier.</summary>
    [IsoId("_g5qmsZZhEfCShM_qO0U4ig")]
    [DisplayName("Digital Ledger Identification")]
    public record DigitalLedgerIdentification : CashSettlementSystemPlace1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DgtlLdgrId")]
        public required IsoDTI2024Identifier Value { get; init; }
    }
}
