// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment8"/>
[IsoId("_yLKiITEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Amendment8")]
public partial record MandateAmendment8
{
    /// <inheritdoc cref="IMandateAmendment8.AmendmentReason"/>
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason3 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment8.Mandate"/>
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate21 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment8.OriginalMandate"/>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate10Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment8.OriginalMessageInformation"/>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment8.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
