// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform8Choice
{
    /// <summary>Transaction to perform expressed as a payment request.</summary>
    [IsoId("_By-kQbZaEfCUZfsQO4rYeA")]
    [DisplayName("Payment Request")]
    public record PaymentRequest : TransactionToPerform8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PmtReq")]
        public required PaymentRequest8 Value { get; init; }
    }
}
