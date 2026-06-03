// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Provides data related to a request.</summary>
    [IsoId("6e22c992-4cdf-4949-b95c-ae20967934bb")]
    [DisplayName("Transaction Data")]
    public record TransactionData : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TxData")]
        public required TransactionAmendment1 Value { get; init; }
    }
}
