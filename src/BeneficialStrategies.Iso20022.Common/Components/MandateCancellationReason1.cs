// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellationReason1"/>
[IsoId("_HSwZ2249EeiU9cctagi5ow")]
[DisplayName("Mandate Cancellation Reason")]
public partial record MandateCancellationReason1
{
    /// <inheritdoc cref="IMandateCancellationReason1.Originator"/>
    [IsoId("_Hfkt0249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <inheritdoc cref="IMandateCancellationReason1.Reason"/>
    [IsoId("_Hfkt1W49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="IMandateCancellationReason1.AdditionalInformation"/>
    [IsoId("_Hfkt1249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
