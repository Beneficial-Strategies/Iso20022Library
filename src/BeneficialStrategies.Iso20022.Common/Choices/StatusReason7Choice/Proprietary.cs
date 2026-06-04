// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatusReason7Choice
{
    /// <summary>Status reason expressed as a proprietary code.</summary>
    [IsoId("_nLSClakxEeynsLtPxJMJTQ")]
    [DisplayName("Proprietary")]
    public record Proprietary : StatusReason7Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification1 Value { get; init; }
    }
}
