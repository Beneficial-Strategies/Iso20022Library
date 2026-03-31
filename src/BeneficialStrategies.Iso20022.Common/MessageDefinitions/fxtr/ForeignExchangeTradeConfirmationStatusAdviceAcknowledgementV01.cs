// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.038.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationStatusAdviceAcknowledgement message is sent from a market participant to a Central matching utility (CMU) in response to the FXTradeConfirmationStatusAdvice previously sent by the CMU in the scenario of trades matched by both participants.
///
/// Usage
/// The acknowledgement is sent by the trading member to the CMU after they received the confirmation status advice.
/// Note that one confirmation status advice acknowledgement responds to one confirmation status advice.
/// </summary>
[Description(
    @"Scope|The ForeignExchangeTradeConfirmationStatusAdviceAcknowledgement message is sent from a market participant to a Central matching utility (CMU) in response to the FXTradeConfirmationStatusAdvice previously sent by the CMU in the scenario of trades matched by both participants.||Usage|The acknowledgement is sent by the trading member to the CMU after they received the confirmation status advice. |Note that one confirmation status advice acknowledgement responds to one confirmation status advice."
)]
[IsoId("_4rvHkER_EeStEe_B2dcrqg")]
[DisplayName("Foreign Exchange Trade Confirmation Status Advice Acknowledgement V")]
public record ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.038.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfStsAdvcAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.038.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of the advice acknowledgement.
    /// </summary>
    [IsoId("_BRy-cESAEeStEe_B2dcrqg")]
    [DisplayName("Advice Acknowledgement Identification")]
    [IsoXmlTag("AdvcAckId")]
    public MessageIdentification1? AdviceAcknowledgementIdentification { get; init; }

    /// <summary>
    /// Identification of the request.
    /// </summary>
    [IsoId("__tUJkESjEeS6cOLECtYLrA")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Specifies the date on which the trade was executed.
    /// </summary>
    [IsoId("_TqsBUESAEeStEe_B2dcrqg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_qe6B0IsSEeS_1fMypAW06w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TradeIdentification { get; init; }

    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_wbqUIIsSEeS_1fMypAW06w")]
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public required TradingModeType1Code TradingMode { get; init; }

    /// <summary>
    /// Identifies the status of the confirmation acknowledgement.
    /// </summary>
    [IsoId("_viJsEESvEeSTS-T7FO4CUQ")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public required AffirmStatus1Code AffirmationStatus { get; init; }

    /// <summary>
    /// Identifies the status of the confirmation.
    /// </summary>
    [IsoId("_pYBHsIsREeS_1fMypAW06w")]
    [DisplayName("Confirmation Status")]
    [IsoXmlTag("ConfSts")]
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; }

    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_RD1T0ESAEeStEe_B2dcrqg")]
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    public required MarketIdentification88 MarketIdentification { get; init; }

    /// <summary>
    /// Free format text string.
    /// </summary>
    [IsoId("_aiEI0ESAEeStEe_B2dcrqg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation5? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1wlvYKHlEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01.
