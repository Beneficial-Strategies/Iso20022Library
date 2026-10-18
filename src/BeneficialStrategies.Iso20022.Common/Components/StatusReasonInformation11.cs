// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStatusReasonInformation11"/>
[IsoId("_mOivAbTREeeyuKckOGlwuA")]
[DisplayName("Status Reason Information")]
public partial record StatusReasonInformation11
{
    /// <inheritdoc cref="IStatusReasonInformation11.Originator"/>
    [IsoId("_mWiNZbTREeeyuKckOGlwuA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation11.Reason"/>
    [IsoId("_mWiNZ7TREeeyuKckOGlwuA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation11.AdditionalInformation"/>
    [IsoId("_mWiNabTREeeyuKckOGlwuA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
