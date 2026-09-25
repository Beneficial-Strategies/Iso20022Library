// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountReportOrError4Choice
{
    /// <summary>
    /// Error that occurred during processing.
    /// </summary>
    [IsoId("_1Pl8cTEyEe6g-ffJsqGiSA")]
    [DisplayName("Error")]
    public record Error : AccountReportOrError4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Err")]
        public required ErrorHandling5 Value { get; init; }
    }
}
