// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Response to a token computation.</summary>
    [IsoId("_tKIfc7YJEfCUZfsQO4rYeA")]
    [DisplayName("Token Response")]
    public record TokenResponse : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TknRspn")]
        public required TokenRequestComponent6 Value { get; init; }
    }
}
