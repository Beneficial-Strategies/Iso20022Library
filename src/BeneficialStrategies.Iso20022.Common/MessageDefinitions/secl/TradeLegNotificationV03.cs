// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.001.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TradeLegNotification message is sent by the central counterparty (CCP) to a clearing member to report the trade that has been executed by the trading platform.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The CCP reports both sides of the trade from the clearing member perspective. The CCP sends a message to the global clearing member of the seller and a message to the global clearing member of the buyer. Note: An individual clearing member only clear its own trades.
/// </summary>
[Description(@"Scope|The TradeLegNotification message is sent by the central counterparty (CCP) to a clearing member to report the trade that has been executed by the trading platform.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CCP reports both sides of the trade from the clearing member perspective. The CCP sends a message to the global clearing member of the seller and a message to the global clearing member of the buyer. Note: An individual clearing member only clear its own trades.")]
[IsoId("_BjjyQS0mEeSRe9rElPHBfg")]
[DisplayName("Trade Leg Notification V")]
public partial record TradeLegNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.001.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradLegNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.001.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_BjjyRS0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member account at the CCP through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_BjjyRy0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public required SecuritiesAccount18 ClearingAccount { get; init; } 
    
    /// <summary>
    /// An account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_BjjySS0mEeSRe9rElPHBfg")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    
    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_BjjySy0mEeSRe9rElPHBfg")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    /// <summary>
    /// Provides clearing details such as the settlement netting (or not) eligibility code or the clearing segment.
    /// </summary>
    [IsoId("_BjjyTS0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing4? ClearingDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the trade leg such as the trade date, the settlement date or the trading currency.
    /// </summary>
    [IsoId("_BjjyTy0mEeSRe9rElPHBfg")]
    [DisplayName("Trade Leg Details")]
    [IsoXmlTag("TradLegDtls")]
    public required TradeLeg8 TradeLegDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the settlement details of the trade leg such the settlement amount or the place of settlement.
    /// </summary>
    [IsoId("_BjjyUS0mEeSRe9rElPHBfg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required Settlement1 SettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BjjyUy0mEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TradeLegNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeLegNotificationV03.

