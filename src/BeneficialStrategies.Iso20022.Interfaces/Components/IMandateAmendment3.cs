// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_5sMy4SmeEeKdFJmzhTDOvQ")]
public interface IMandateAmendment3 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_5_bQ5SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_5_bQ6SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    IMandateAmendmentReason1 AmendmentReason { get; }

    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_5_bQ7SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate3 Mandate { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_5_bQ8SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate2Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6UlolimeEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
