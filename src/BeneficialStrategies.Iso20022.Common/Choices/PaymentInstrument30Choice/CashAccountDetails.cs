// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice
{
    /// <summary>Cash account details.</summary>
    [IsoId("8a29842a-e293-46fd-b5c2-d595296d2d5c")]
    [DisplayName("Cash Account Details")]
    public record CashAccountDetails : PaymentInstrument30Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAcctDtls")]
        public required InvestmentAccount60 Value { get; init; }
    }
}
