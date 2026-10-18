// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_ZoVqAW49EeiU9cctagi5ow")]
public interface IMandateAcceptance6 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_ZyBKdW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    [IsoId("_ZyBKd249EeiU9cctagi5ow")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    IAcceptanceResult6 AcceptanceResult { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_ZyBKeW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate7Choice? OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ZyBKe249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
