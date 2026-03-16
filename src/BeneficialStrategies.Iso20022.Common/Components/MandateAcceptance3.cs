// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_2NI1kSmfEeKdFJmzhTDOvQ")]
[DisplayName("Mandate Acceptance")]
public record MandateAcceptance3
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_2hQEZSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    [IsoId("_2hQEaSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_2hQEbSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7KYLoCmfEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
