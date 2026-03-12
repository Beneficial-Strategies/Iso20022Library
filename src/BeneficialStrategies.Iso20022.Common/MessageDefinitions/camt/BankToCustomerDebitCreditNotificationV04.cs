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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.054.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.
/// </summary>
[Description(@"Scope|The BankToCustomerDebitCreditNotification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The BankToCustomerDebitCreditNotification message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|The BankToCustomerDebitCreditNotification message can be used to: |- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries.|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information.")]
[IsoId("_7yqioSGnEeKjd4jizyIDGA")]
[DisplayName("Bank To Customer Debit Credit Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankToCustomerDebitCreditNotificationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.054.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrDbtCdtNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.054.001.04";
    
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
    /// Constructs a BankToCustomerDebitCreditNotificationV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankToCustomerDebitCreditNotificationV04( GroupHeader58 reqGroupHeader,AccountNotification7 reqNotification )
    {
        GroupHeader = reqGroupHeader;
        Notification = reqNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_7yqipyGnEeKjd4jizyIDGA")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader58 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader58 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader58 GroupHeader { get; init; } 
    #else
    public GroupHeader58 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Notifies debit and credit entries for the account.
    /// </summary>
    [IsoId("_7yqiqyGnEeKjd4jizyIDGA")]
    [DisplayName("Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntfctn")]
    #endif
    [IsoXmlTag("Ntfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountNotification7 Notification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountNotification7 Notification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountNotification7 Notification { get; init; } 
    #else
    public AccountNotification7 Notification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7yqiryGnEeKjd4jizyIDGA")]
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


// Since BankToCustomerDebitCreditNotificationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankToCustomerDebitCreditNotificationV04.

