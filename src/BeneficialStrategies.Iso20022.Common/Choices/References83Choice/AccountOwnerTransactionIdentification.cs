// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the account owner transaction identification.</summary>
    [IsoId("_WtzlsagzEfCXwLUUylXgrQ")]
    [DisplayName("Account Owner Transaction Identification")]
    public record AccountOwnerTransactionIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AcctOwnrTxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
