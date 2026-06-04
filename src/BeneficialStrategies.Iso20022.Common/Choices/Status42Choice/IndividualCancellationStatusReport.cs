// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status42Choice
{
    /// <summary>Status expressed as individual cancellation status report.</summary>
    [IsoId("3778c74f-9ca1-4138-925d-aa5dabf3b78f")]
    [DisplayName("Individual Cancellation Status Report")]
    public record IndividualCancellationStatusReport : Status42Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("IndvCxlStsRpt")]
        public required IndividualOrderStatusAndReason10 Value { get; init; }
    }
}
