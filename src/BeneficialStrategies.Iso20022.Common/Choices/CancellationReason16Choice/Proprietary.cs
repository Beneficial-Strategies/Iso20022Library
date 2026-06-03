// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason16Choice
{
    /// <summary>Reason for the cancellation request, in a proprietary form.</summary>
    [IsoId("_jG-UEe5NEeCisYr99QEiWA_-734160402")]
    [DisplayName("Proprietary")]
    public record Proprietary : CancellationReason16Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
