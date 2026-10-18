// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, for which a copy of the details is requested.
/// </summary>
[IsoId("_fytnkH5gEea7cqFPsAF3tQ")]
public interface IMandateCopy1 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_P7yVsH5hEea7cqFPsAF3tQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_v8iK0H5gEea7cqFPsAF3tQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate4Choice OriginalMandate { get; }

    /// <summary>
    /// Indicates the status of the mandate.
    /// </summary>
    [IsoId("_XY87UJm_Eeao_Z127E9uYg")]
    [DisplayName("Mandate Status")]
    [IsoXmlTag("MndtSts")]
    IMandateStatus1Choice? MandateStatus { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IoCecH5lEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
