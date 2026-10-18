// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReturnReasonInformation9"/>
[IsoId("_TQDZg9p-Ed-ak6NoX_4Aeg_-415808124")]
[DisplayName("Return Reason Information")]
public partial record ReturnReasonInformation9
{
    /// <inheritdoc cref="IReturnReasonInformation9.Originator"/>
    [IsoId("_TQDZhNp-Ed-ak6NoX_4Aeg_-415807751")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <inheritdoc cref="IReturnReasonInformation9.Reason"/>
    [IsoId("_TQDZhdp-Ed-ak6NoX_4Aeg_-415807661")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReturnReason5Choice_? Reason { get; init; }

    /// <inheritdoc cref="IReturnReasonInformation9.AdditionalInformation"/>
    [IsoId("_TQDZhtp-Ed-ak6NoX_4Aeg_-415808122")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
