// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendment1"/>
[IsoId("_RBcz9tp-Ed-ak6NoX_4Aeg_-453440412")]
[DisplayName("Mandate Amendment")]
public partial record MandateAmendment1
{
    /// <inheritdoc cref="IMandateAmendment1.OriginalMessageInformation"/>
    [IsoId("_RBcz99p-Ed-ak6NoX_4Aeg_344631630")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAmendment1.AmendmentReason"/>
    [IsoId("_RBcz-Np-Ed-ak6NoX_4Aeg_-995812636")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required AmendmentReasonInformation1 AmendmentReason { get; init; }

    /// <inheritdoc cref="IMandateAmendment1.Mandate"/>
    [IsoId("_RBmk8Np-Ed-ak6NoX_4Aeg_-1140806205")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required MandateInformation3 Mandate { get; init; }

    /// <inheritdoc cref="IMandateAmendment1.OriginalMandate"/>
    [IsoId("_RBmk8dp-Ed-ak6NoX_4Aeg_75619015")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate1Choice_ OriginalMandate { get; init; }
}
