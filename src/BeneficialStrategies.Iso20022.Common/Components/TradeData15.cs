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
[IsoId("_M6hocZU8EeaYkf5FCqYMeA")]
[DisplayName("Trade Data")]
public record TradeData15
{
    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_NE9W05U8EeaYkf5FCqYMeA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_NE9W1ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginatorReference { get; init; }

    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_NE9W15U8EeaYkf5FCqYMeA")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_NE9W2ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; }

    /// <summary>
    /// Identification to the unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    [IsoId("_NE9W25U8EeaYkf5FCqYMeA")]
    [DisplayName("Matching System Matched Side Reference")]
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; }

    /// <summary>
    /// Party that assigned the status to the foreign exchange or derivative trade.
    /// </summary>
    [IsoId("_NE9W3ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20, MinimumLength = 1)]
    public IsoMax20Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_NE9W35U8EeaYkf5FCqYMeA")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus2 CurrentStatus { get; init; }

    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_NE9W4ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType2Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_NE9W45U8EeaYkf5FCqYMeA")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_NE9W5ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status28Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_NE9W55U8EeaYkf5FCqYMeA")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType2Code? PreviousStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the previous status was assigned.
    /// </summary>
    [IsoId("_NE9W6ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Previous Status Date Time")]
    [IsoXmlTag("PrvsStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? PreviousStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_NE9W65U8EeaYkf5FCqYMeA")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_NE9W7ZU8EeaYkf5FCqYMeA")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }

    /// <summary>
    /// To indicate if the trade is split.
    /// </summary>
    [IsoId("_NE9W75U8EeaYkf5FCqYMeA")]
    [DisplayName("Split Trade Indicator")]
    [IsoXmlTag("SpltTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SplitTradeIndicator { get; init; }
}
