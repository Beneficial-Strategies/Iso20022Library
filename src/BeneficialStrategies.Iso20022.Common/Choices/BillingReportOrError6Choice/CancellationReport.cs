// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BillingReportOrError6Choice
{
    /// <summary>Report on cancelled billing data.</summary>
    [IsoId("_2jks0zEyEe6g-ffJsqGiSA")]
    [DisplayName("Cancellation Report")]
    public record CancellationReport : BillingReportOrError6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CxlRpt")]
        public required BillingCancellationReport3 Value { get; init; }
    }
}
