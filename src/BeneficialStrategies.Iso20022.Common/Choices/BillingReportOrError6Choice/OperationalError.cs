// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BillingReportOrError6Choice
{
    /// <summary>Indicates that an operational error has been issued during the processing of the related request.</summary>
    [IsoId("_2jks1TEyEe6g-ffJsqGiSA")]
    [DisplayName("Operational Error")]
    public record OperationalError : BillingReportOrError6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("OprlErr")]
        public required ErrorHandling5 Value { get; init; }
    }
}
