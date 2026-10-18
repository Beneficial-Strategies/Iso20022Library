// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_cU1IoUjwEeaVLL5QKJ4f-A")]
public interface IMandateAmendment5 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_cdsww0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_cdswxUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    IMandateAmendmentReason1 AmendmentReason { get; }

    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_cdswx0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate8 Mandate { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_cdswyUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate4Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_cdy3YUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
