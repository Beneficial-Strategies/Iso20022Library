// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStatusReasonInformation12"/>
[IsoId("_E6Ui6W49EeiU9cctagi5ow")]
[DisplayName("Status Reason Information")]
public partial record StatusReasonInformation12
{
    /// <inheritdoc cref="IStatusReasonInformation12.Originator"/>
    [IsoId("_FD25VW49EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation12.Reason"/>
    [IsoId("_FD25V249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation12.AdditionalInformation"/>
    [IsoId("_FD25WW49EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
