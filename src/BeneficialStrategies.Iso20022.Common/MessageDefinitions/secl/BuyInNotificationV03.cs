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
/// This record is an implementation of the secl.007.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BuyInNotification message is sent by the central counterparty (CCP) to a clearing member to notify the start of the buy in process.
/// 
/// The message definition is intended for use with the ISO 20022 Business Application Header.
/// 
/// Usage
/// The buy in process is a process by which the CCP buys in stocks to cover failed transactions; the clearing member is notified that this process has started. Depending on each CCP internal rules, this message can also be sent, as a warning, by the central counterparty to the clearing member some days before the buy in process starts.
/// </summary>
[Description(@"Scope|The BuyInNotification message is sent by the central counterparty (CCP) to a clearing member to notify the start of the buy in process.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The buy in process is a process by which the CCP buys in stocks to cover failed transactions; the clearing member is notified that this process has started. Depending on each CCP internal rules, this message can also be sent, as a warning, by the central counterparty to the clearing member some days before the buy in process starts.")]
[IsoId("_1K820S0lEeSRe9rElPHBfg")]
[DisplayName("Buy In Notification V")]
public partial record BuyInNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.007.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.007.001.03";
    
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
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_1K821S0lEeSRe9rElPHBfg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_1K821y0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    
    /// <summary>
    /// Indicates if the message is a notification or a warning and gives the option to specify the buy in date.
    /// </summary>
    [IsoId("_1K822S0lEeSRe9rElPHBfg")]
    [DisplayName("Notification Details")]
    [IsoXmlTag("NtfctnDtls")]
    public BuyIn4? NotificationDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.
    /// </summary>
    [IsoId("_1K822y0lEeSRe9rElPHBfg")]
    [DisplayName("Original Settlement Obligation")]
    [IsoXmlTag("OrgnlSttlmOblgtn")]
    public required SettlementObligation7 OriginalSettlementObligation { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1K823S0lEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since BuyInNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInNotificationV03.

