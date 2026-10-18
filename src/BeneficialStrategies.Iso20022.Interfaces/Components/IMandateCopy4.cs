// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Copy4.
/// </summary>
[IsoId("_5GXZsTEyEe6g-ffJsqGiSA")]
public interface IMandateCopy4 : IIsoComponent
{
    /// <summary>
    /// Mandate Status.
    /// </summary>
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    IMandateStatus1Choice? MandateStatus { get; }

    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate10Choice OriginalMandate { get; }

    /// <summary>
    /// Original Message Information.
    /// </summary>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
