// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountReportOrError4Choice
{
    /// <summary>
    /// Requested details of the account.
    /// </summary>
    [IsoId("_1Pl8czEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Report")]
    public record AccountReport : AccountReportOrError4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AcctRpt")]
        public required AccountReport34 Value { get; init; }
    }
}
