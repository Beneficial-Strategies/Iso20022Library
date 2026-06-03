// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Card payment transaction including an authorisation response.</summary>
    [IsoId("_tKIfZ7YJEfCUZfsQO4rYeA")]
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AuthstnRspn")]
        public required CardPaymentDataSetTransaction57 Value { get; init; }
    }
}
