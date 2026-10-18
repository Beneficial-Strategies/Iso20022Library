// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment4"/>
[IsoId("_YCiq5x77EeSxevWRRWxNAg")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment4
{
    /// <inheritdoc cref="IMandateAmendment4.OriginalMessageInformation"/>
    [IsoId("_YThGIx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment4.AmendmentReason"/>
    [IsoId("_YThGJR77EeSxevWRRWxNAg")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment4.Mandate"/>
    [IsoId("_YThGJx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate6 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment4.OriginalMandate"/>
    [IsoId("_YThGKR77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate3Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment4.SupplementaryData"/>
    [IsoId("_YThGKx77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
