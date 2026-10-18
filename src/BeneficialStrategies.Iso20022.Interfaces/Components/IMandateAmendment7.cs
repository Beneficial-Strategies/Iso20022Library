// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_eSRVgdcZEeqRFcf2R4bPBw")]
public interface IMandateAmendment7 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_eToncdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_eTonc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    IMandateAmendmentReason2 AmendmentReason { get; }

    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_eTonddcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate18 Mandate { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_eTond9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate9Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eTonedcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
