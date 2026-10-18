// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStatusReasonInformation8"/>
[IsoId("_TRPsUNp-Ed-ak6NoX_4Aeg_1156620566")]
[DisplayName("Status Reason Information")]
public partial record StatusReasonInformation8
{
    /// <inheritdoc cref="IStatusReasonInformation8.Originator"/>
    [IsoId("_TRPsUdp-Ed-ak6NoX_4Aeg_1156620782")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation8.Reason"/>
    [IsoId("_TRPsUtp-Ed-ak6NoX_4Aeg_1156620691")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; }

    /// <inheritdoc cref="IStatusReasonInformation8.AdditionalInformation"/>
    [IsoId("_TRPsU9p-Ed-ak6NoX_4Aeg_1156620597")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
