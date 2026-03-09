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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BuyInNotificationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyInNotificationV03( PartyIdentification35Choice_ reqClearingMember,SettlementObligation7 reqOriginalSettlementObligation )
    {
        ClearingMember = reqClearingMember;
        OriginalSettlementObligation = reqOriginalSettlementObligation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_1K821S0lEeSRe9rElPHBfg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_1K821y0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ ClearingMember { get; init; } 
    #else
    public PartyIdentification35Choice_ ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the message is a notification or a warning and gives the option to specify the buy in date.
    /// </summary>
    [IsoId("_1K822S0lEeSRe9rElPHBfg")]
    [DisplayName("Notification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnDtls")]
    #endif
    [IsoXmlTag("NtfctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BuyIn4? NotificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BuyIn4? NotificationDetails { get; init; } 
    #else
    public BuyIn4? NotificationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.
    /// </summary>
    [IsoId("_1K822y0lEeSRe9rElPHBfg")]
    [DisplayName("Original Settlement Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlSttlmOblgtn")]
    #endif
    [IsoXmlTag("OrgnlSttlmOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementObligation7 OriginalSettlementObligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementObligation7 OriginalSettlementObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementObligation7 OriginalSettlementObligation { get; init; } 
    #else
    public SettlementObligation7 OriginalSettlementObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1K823S0lEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since BuyInNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInNotificationV03.

