// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_YCiq5x77EeSxevWRRWxNAg")]
[DisplayName("Mandate Amendment")]
public record MandateAmendment4
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_YThGIx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    [IsoId("_YThGJR77EeSxevWRRWxNAg")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; }

    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    [IsoId("_YThGJx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate6 Mandate { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_YThGKR77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate3Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_YThGKx77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
