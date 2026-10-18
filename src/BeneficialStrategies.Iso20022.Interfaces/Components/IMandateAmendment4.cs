// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_YCiq5x77EeSxevWRRWxNAg")]
public interface IMandateAmendment4 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_YThGIx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_YThGJR77EeSxevWRRWxNAg")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    IMandateAmendmentReason1 AmendmentReason { get; }

    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_YThGJx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate6 Mandate { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_YThGKR77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate3Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YThGKx77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
