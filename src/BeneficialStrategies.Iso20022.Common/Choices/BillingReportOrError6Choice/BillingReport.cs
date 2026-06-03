// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BillingReportOrError6Choice
{
    /// <summary>Report on billing data.</summary>
    [IsoId("_2jks0TEyEe6g-ffJsqGiSA")]
    [DisplayName("Billing Report")]
    public record BillingReport : BillingReportOrError6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("BllgRpt")]
        public required BillingReport6 Value { get; init; }
    }
}
