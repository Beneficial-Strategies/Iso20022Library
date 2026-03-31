// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_7KIJAZR3Eeak6e8_Fc5fQg")]
[DisplayName("Trade Data")]
public record TradeData12
{
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_7WM2I5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Party that assigned the status to the foreign exchange trade.
    /// </summary>
    [IsoId("_7WM2JZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_7WM2J5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus2 CurrentStatus { get; init; }

    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_7WM2KZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType2Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned to all the trades, unless overwritten by a date and time assigned to an individual trade.
    /// </summary>
    [IsoId("_7WM2K5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_7WM2LZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status28Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_7WM2L5R3Eeak6e8_Fc5fQg")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType2Code? PreviousStatusSubType { get; init; }

    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported, unless overwritten by a product type assigned to an individual trade.
    /// </summary>
    [IsoId("_7WM2MZR3Eeak6e8_Fc5fQg")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    [IsoId("_HDIpMZU6EeaYkf5FCqYMeA")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }

    /// <summary>
    /// The identification that links the quoted trades with a submitted Report issued by a central system.
    /// </summary>
    [IsoId("_V88rQJR4Eeak6e8_Fc5fQg")]
    [DisplayName("Linked Report Identification")]
    [IsoXmlTag("LkdRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkedReportIdentification { get; init; }
}
