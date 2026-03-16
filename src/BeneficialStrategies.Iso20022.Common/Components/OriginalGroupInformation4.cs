// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("_PhVsEtp-Ed-ak6NoX_4Aeg_453123857")]
[DisplayName("Original Group Information")]
public record OriginalGroupInformation4
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_PhVsE9p-Ed-ak6NoX_4Aeg_453123876")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, eg, pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_PhVsFNp-Ed-ak6NoX_4Aeg_453123952")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_PhVsFdp-Ed-ak6NoX_4Aeg_-1547891782")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_PhVsFtp-Ed-ak6NoX_4Aeg_-1239359353")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public ValueList<CancellationReasonInformation1> CancellationReasonInformation { get; init; } =
        [];
}
