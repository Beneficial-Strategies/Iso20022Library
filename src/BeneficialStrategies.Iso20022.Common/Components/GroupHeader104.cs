// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader104"/>
[IsoId("_7o6soQcYEeyTDbUIoCmuCw")]
[DisplayName("Group Header")]
public partial record GroupHeader104
{
    /// <inheritdoc cref="IGroupHeader104.MessageIdentification"/>
    [IsoId("_7ua3sQcYEeyTDbUIoCmuCw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader104.CreationDateTime"/>
    [IsoId("_7ua3swcYEeyTDbUIoCmuCw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader104.NumberOfSettlementRequests"/>
    [IsoId("_7ua3twcYEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Settlement Requests")]
    [IsoXmlTag("NbOfSttlmReqs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfSettlementRequests { get; init; }

    /// <inheritdoc cref="IGroupHeader104.ControlSum"/>
    [IsoId("_7ua3uQcYEeyTDbUIoCmuCw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader104.SettlementInformation"/>
    [IsoId("_7ua3vQcYEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction14? SettlementInformation { get; init; }
}
