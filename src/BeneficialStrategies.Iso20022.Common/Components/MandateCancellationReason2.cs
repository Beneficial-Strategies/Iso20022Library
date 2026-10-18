// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellationReason2"/>
[IsoId("_5w0E6TEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Cancellation Reason2")]
public partial record MandateCancellationReason2
{
    /// <inheritdoc cref="IMandateCancellationReason2.AdditionalInformation"/>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <inheritdoc cref="IMandateCancellationReason2.Originator"/>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <inheritdoc cref="IMandateCancellationReason2.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }
}
