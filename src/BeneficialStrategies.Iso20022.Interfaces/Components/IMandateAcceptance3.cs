// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_2NI1kSmfEeKdFJmzhTDOvQ")]
public interface IMandateAcceptance3 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_2hQEZSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    [IsoId("_2hQEaSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    IAcceptanceResult6 AcceptanceResult { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_2hQEbSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate2Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7KYLoCmfEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
