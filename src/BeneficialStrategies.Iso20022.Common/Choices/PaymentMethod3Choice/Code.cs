// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PaymentMethod3Choice
{
    /// <summary>Method of payment for the remittance of the CSD or NCB to the invoicing party, in a coded form.</summary>
    [IsoId("_63GwkdEvEfCli6pH8hj5ag")]
    [DisplayName("Code")]
    public record Code : PaymentMethod3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalPaymentMethode1Code Value { get; init; }
    }
}
