// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment6"/>
[IsoId("_RwtmcW49EeiU9cctagi5ow")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment6
{
    /// <inheritdoc cref="IMandateAmendment6.OriginalMessageInformation"/>
    [IsoId("_R8fYo249EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment6.AmendmentReason"/>
    [IsoId("_R8fYpW49EeiU9cctagi5ow")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason2 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment6.Mandate"/>
    [IsoId("_R8fYp249EeiU9cctagi5ow")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate14 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment6.OriginalMandate"/>
    [IsoId("_R8fYqW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate6Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment6.SupplementaryData"/>
    [IsoId("_R8fYq249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
