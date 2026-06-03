// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice
{
    /// <summary>Cash account details.</summary>
    [IsoId("c39db804-06a7-4bc5-a244-4a11a700e7ec")]
    [DisplayName("Cash Account Details")]
    public record CashAccountDetails : PaymentInstrument28Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAcctDtls")]
        public required InvestmentAccount60 Value { get; init; }
    }
}
