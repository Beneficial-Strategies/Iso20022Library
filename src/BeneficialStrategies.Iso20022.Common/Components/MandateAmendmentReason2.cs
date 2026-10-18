// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendmentReason2"/>
[IsoId("_SGUqQ249EeiU9cctagi5ow")]
[DisplayName("Mandate Amendment Reason")]
public partial record MandateAmendmentReason2
{
    /// <inheritdoc cref="IMandateAmendmentReason2.Originator"/>
    [IsoId("_SPtPk249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <inheritdoc cref="IMandateAmendmentReason2.Reason"/>
    [IsoId("_SPtPlW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="IMandateAmendmentReason2.AdditionalInformation"/>
    [IsoId("_SPtPl249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
