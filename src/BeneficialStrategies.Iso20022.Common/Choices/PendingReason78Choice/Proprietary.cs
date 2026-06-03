// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason78Choice
{
    /// <summary>Specifies the reason why the instruction has a pending status.</summary>
    [IsoId("1faae361-c659-416a-b77d-d41ab674cee8")]
    [DisplayName("Proprietary")]
    public record Proprietary : PendingReason78Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required GenericIdentification30 Value { get; init; }
    }
}
