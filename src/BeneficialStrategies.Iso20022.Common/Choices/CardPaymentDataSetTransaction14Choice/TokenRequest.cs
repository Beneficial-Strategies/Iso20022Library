// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Request for a token computation.</summary>
    [IsoId("_tKIfbbYJEfCUZfsQO4rYeA")]
    [DisplayName("Token Request")]
    public record TokenRequest : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("TknReq")]
        public required TokenRequestComponent6 Value { get; init; }
    }
}
