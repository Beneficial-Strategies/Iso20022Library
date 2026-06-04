// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status42Choice
{
    /// <summary>Status expressed as cancellation status report.</summary>
    [IsoId("c0f329a9-a243-4b9d-b8f8-0b9924bf16b9")]
    [DisplayName("Cancellation Status Report")]
    public record CancellationStatusReport : Status42Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlStsRpt")]
        public required OrderStatusAndReason12 Value { get; init; }
    }
}
