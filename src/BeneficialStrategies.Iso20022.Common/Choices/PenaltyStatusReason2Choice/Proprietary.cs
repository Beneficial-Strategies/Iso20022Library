// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PenaltyStatusReason2Choice
{
    /// <summary>Penalty status reason, in a proprietary form.</summary>
    [IsoId("_vUsvEx-DEeuwwezkzufkMw")]
    [DisplayName("Proprietary")]
    public record Proprietary : PenaltyStatusReason2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
