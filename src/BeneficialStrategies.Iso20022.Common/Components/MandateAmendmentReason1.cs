// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAmendmentReason1"/>
[IsoId("_t4JrAVkyEeGeoaLUQk__nA_-1184878668")]
[DisplayName("Mandate Amendment Reason")]
public partial record MandateAmendmentReason1
{
    /// <inheritdoc cref="IMandateAmendmentReason1.Originator"/>
    [IsoId("_t4JrAlkyEeGeoaLUQk__nA_-177799544")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <inheritdoc cref="IMandateAmendmentReason1.Reason"/>
    [IsoId("_t4JrA1kyEeGeoaLUQk__nA_-1894437970")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="IMandateAmendmentReason1.AdditionalInformation"/>
    [IsoId("_t4JrBFkyEeGeoaLUQk__nA_-2110542685")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
