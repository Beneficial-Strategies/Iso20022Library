// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment5"/>
[IsoId("_cU1IoUjwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment5
{
    /// <inheritdoc cref="IMandateAmendment5.OriginalMessageInformation"/>
    [IsoId("_cdsww0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment5.AmendmentReason"/>
    [IsoId("_cdswxUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason1 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment5.Mandate"/>
    [IsoId("_cdswx0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate8 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment5.OriginalMandate"/>
    [IsoId("_cdswyUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment5.SupplementaryData"/>
    [IsoId("_cdy3YUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
