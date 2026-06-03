// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType127Choice
{
    /// <summary>Event type expressed as a code.</summary>
    [IsoId("_z49Xo6NZEfC9id413JK-Ig")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType127Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType126Choice_ Value { get; init; }
    }
}
