// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction14Choice
{
    /// <summary>Card payment transaction including an authorisation request.</summary>
    [IsoId("_tKIfYbYJEfCUZfsQO4rYeA")]
    [DisplayName("Authorisation Request")]
    public record AuthorisationRequest : CardPaymentDataSetTransaction14Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AuthstnReq")]
        public required CardPaymentDataSetTransaction56 Value { get; init; }
    }
}
