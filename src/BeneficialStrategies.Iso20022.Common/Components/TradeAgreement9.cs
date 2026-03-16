// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
[IsoId("_U6W0USNfEeKkK9gFRqAdSA")]
[DisplayName("Trade Agreement")]
public record TradeAgreement9
{
    /// <summary>
    /// Date on which the trading parties agreed on the trade.
    /// </summary>
    [IsoId("_VGS-nCNfEeKkK9gFRqAdSA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_7ldMoDqLEeKXK8qRvydwAw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_VGS-oyNfEeKkK9gFRqAdSA")]
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginatorReference { get; init; }

    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_VGTlpSNfEeKkK9gFRqAdSA")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_VGTlrCNfEeKkK9gFRqAdSA")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; }

    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_VGTlsyNfEeKkK9gFRqAdSA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; }

    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_mfUsBTm9EeKBIOJJJzlg2Q")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    [IsoId("_VGTluiNfEeKkK9gFRqAdSA")]
    [DisplayName("Operation Type")]
    [IsoXmlTag("OprTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? OperationType { get; init; }

    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example, agent (AGNT).
    /// </summary>
    [IsoId("_VGTlwSNfEeKkK9gFRqAdSA")]
    [DisplayName("Operation Scope")]
    [IsoXmlTag("OprScp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? OperationScope { get; init; }

    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_VGTlyCNfEeKkK9gFRqAdSA")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }

    /// <summary>
    /// To indicate if the trade is split.
    /// </summary>
    [IsoId("_h1IosCNfEeKkK9gFRqAdSA")]
    [DisplayName("Split Trade Indicator")]
    [IsoXmlTag("SpltTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SplitTradeIndicator { get; init; }
}
