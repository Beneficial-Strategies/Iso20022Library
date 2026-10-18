// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment3"/>
[IsoId("_5sMy4SmeEeKdFJmzhTDOvQ")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment3
{
    /// <inheritdoc cref="IMandateAmendment3.OriginalMessageInformation"/>
    [IsoId("_5_bQ5SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment3.AmendmentReason"/>
    [IsoId("_5_bQ6SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment3.Mandate"/>
    [IsoId("_5_bQ7SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate3 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment3.OriginalMandate"/>
    [IsoId("_5_bQ8SmeEeKdFJmzhTDOvQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment3.SupplementaryData"/>
    [IsoId("_6UlolimeEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
