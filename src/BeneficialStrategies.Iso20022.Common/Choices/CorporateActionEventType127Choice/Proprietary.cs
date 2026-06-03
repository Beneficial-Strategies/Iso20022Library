// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType127Choice
{
    /// <summary>Event type expressed as a proprietary code.</summary>
    [IsoId("_z49Xq6NZEfC9id413JK-Ig")]
    [DisplayName("Proprietary")]
    public record Proprietary : CorporateActionEventType127Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
