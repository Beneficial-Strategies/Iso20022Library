// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason16Choice
{
    /// <summary>Reason for the cancellation request, in a coded form.</summary>
    [IsoId("_jG-UEO5NEeCisYr99QEiWA_-1774194697")]
    [DisplayName("Code")]
    public record Code : CancellationReason16Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}
