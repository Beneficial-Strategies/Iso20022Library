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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.009.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallDisputeNotification message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to acknowledge the notification of the dispute (either full or partial dispute) of the MarginCallRequest. The message will detail the amount of the dispute and the reason.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// When there is a dispute by the collateral giver to the collateral taker a MarginCallDisputeNotification message is sent with the disputed amount (full or partial) stating the reason why the margin call is being disputed.
/// </summary>
[Description(@"Scope|The MarginCallDisputeNotification message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to acknowledge the notification of the dispute (either full or partial dispute) of the MarginCallRequest. The message will detail the amount of the dispute and the reason.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When there is a dispute by the collateral giver to the collateral taker a MarginCallDisputeNotification message is sent with the disputed amount (full or partial) stating the reason why the margin call is being disputed.")]
[IsoId("_J4YkdSgrEeyB747fKu7_rw")]
[DisplayName("Margin Call Dispute Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCallDisputeNotificationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.009.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallDsptNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.009.001.05";
    
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
    /// Constructs a MarginCallDisputeNotificationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCallDisputeNotificationV05( System.String reqTransactionIdentification,Obligation9 reqObligation,DisputeNotification2Choice_ reqDisputeNotification )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        DisputeNotification = reqDisputeNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkeygrEeyB747fKu7_rw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkfSgrEeyB747fKu7_rw")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation9 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation9 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation9 Obligation { get; init; } 
    #else
    public Obligation9 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the dispute notification.
    /// </summary>
    [IsoId("_J4YkfygrEeyB747fKu7_rw")]
    [DisplayName("Dispute Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptNtfctn")]
    #endif
    [IsoXmlTag("DsptNtfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DisputeNotification2Choice_ DisputeNotification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DisputeNotification2Choice_ DisputeNotification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeNotification2Choice_ DisputeNotification { get; init; } 
    #else
    public DisputeNotification2Choice_ DisputeNotification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkgSgrEeyB747fKu7_rw")]
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


// Since MarginCallDisputeNotificationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginCallDisputeNotificationV05.

