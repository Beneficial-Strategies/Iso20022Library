// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_d7WRbx77EeSxevWRRWxNAg")]
[DisplayName("Mandate Cancellation")]
public record MandateCancellation4
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_eMUskx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_eMUslR77EeSxevWRRWxNAg")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_eMUslx77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate3Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eMUsmR77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
