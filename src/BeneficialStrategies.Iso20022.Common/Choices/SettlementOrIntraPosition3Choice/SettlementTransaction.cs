// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrIntraPosition3Choice
{
    /// <summary>Settlement transaction details.</summary>
    [IsoId("_TgJxc2p9EemmaZLSPtWX5A")]
    [DisplayName("Settlement Transaction")]
    public record SettlementTransaction : SettlementOrIntraPosition3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("SttlmTx")]
        public required TransactionDetails126 Value { get; init; }
    }
}
