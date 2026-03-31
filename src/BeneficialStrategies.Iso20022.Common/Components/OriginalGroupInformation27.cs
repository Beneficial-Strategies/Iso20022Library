// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original group, to which the message refers.
/// </summary>
[IsoId("_6x8aIRdSEea6o_d8S96x5g")]
[DisplayName("Original Group Information")]
public record OriginalGroupInformation27
{
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_7FfoQxdSEea6o_d8S96x5g")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_7FfoRRdSEea6o_d8S96x5g")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_7FfoRxdSEea6o_d8S96x5g")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    [IsoId("_7FfoSRdSEea6o_d8S96x5g")]
    [DisplayName("Original Number Of Transactions")]
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    [IsoId("_7FfoSxdSEea6o_d8S96x5g")]
    [DisplayName("Original Control Sum")]
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalControlSum { get; init; }
}
