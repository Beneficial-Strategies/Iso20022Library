// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice
{
    /// <summary>Cash account details.</summary>
    [IsoId("e109de48-2805-493d-a978-354f6d4880a9")]
    [DisplayName("Cash Account Details")]
    public record CashAccountDetails : PaymentInstrument29Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CshAcctDtls")]
        public required InvestmentAccount60 Value { get; init; }
    }
}
