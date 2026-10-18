// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment7"/>
[IsoId("_eSRVgdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment7
{
    /// <inheritdoc cref="IMandateAmendment7.OriginalMessageInformation"/>
    [IsoId("_eToncdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment7.AmendmentReason"/>
    [IsoId("_eTonc9cZEeqRFcf2R4bPBw")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason2 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment7.Mandate"/>
    [IsoId("_eTonddcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate18 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment7.OriginalMandate"/>
    [IsoId("_eTond9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate9Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment7.SupplementaryData"/>
    [IsoId("_eTonedcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
