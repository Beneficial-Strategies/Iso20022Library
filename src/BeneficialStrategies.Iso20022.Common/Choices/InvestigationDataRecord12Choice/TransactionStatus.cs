// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Provides the status of a payment that has not yet debited or credited an account.</summary>
    [IsoId("9060ef9e-db1a-4f60-aef1-9d675907c4ab")]
    [DisplayName("Transaction Status")]
    public record TransactionStatus : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TxSts")]
        public required PaymentTransactionStatus1 Value { get; init; }
    }
}
