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

namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TradeLegNotificationCancellation message is sent by the central counterparty (CCP) to a clearing member to notify the cancellation of a TradeLegNotification message previously sent.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// The previously sent message must be the Trade Leg Notification message.
/// </summary>
[Description(
    @"Scope|The TradeLegNotificationCancellation message is sent by the central counterparty (CCP) to a clearing member to notify the cancellation of a TradeLegNotification message previously sent.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The previously sent message must be the Trade Leg Notification message."
)]
[IsoId("__kMikS0lEeSRe9rElPHBfg")]
[DisplayName("Trade Leg Notification Cancellation V")]
public record TradeLegNotificationCancellationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.002.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradLegNtfctnCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.002.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("__kMilS0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; }

    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared.
    /// </summary>
    [IsoId("__kMily0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required SecuritiesAccount18 ClearingAccount { get; init; }

    /// <summary>
    /// An account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("__kNJoS0lEeSRe9rElPHBfg")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("__kNJoy0lEeSRe9rElPHBfg")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; }

    /// <summary>
    /// Provides clearing details such as the non clearing member identification or the settlement netting (or not) eligibility code.
    /// </summary>
    [IsoId("__kNJpS0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing4? ClearingDetails { get; init; }

    /// <summary>
    /// Provides details about the trade leg such as the trade date, the settlement date or the trading currency.
    /// </summary>
    [IsoId("__kNJpy0lEeSRe9rElPHBfg")]
    [DisplayName("Trade Leg Details")]
    [IsoXmlTag("TradLegDtls")]
    public required TradeLeg8 TradeLegDetails { get; init; }

    /// <summary>
    /// Provides details about the settlement details of the trade leg such as the settlement currency or the place of settlement.
    /// </summary>
    [IsoId("__kNJqS0lEeSRe9rElPHBfg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required Settlement1 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("__kNJqy0lEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since TradeLegNotificationCancellationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeLegNotificationCancellationV03.
