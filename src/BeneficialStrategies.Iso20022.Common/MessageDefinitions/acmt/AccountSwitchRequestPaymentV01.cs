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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.034.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).
/// </summary>
[Description(@"The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).")]
[IsoId("_I_e4khMMEeSTk5fcu7tr9w")]
[DisplayName("Account Switch Request Payment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchRequestPaymentV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.034.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqPmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.034.001.01";
    
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
    /// Constructs a AccountSwitchRequestPaymentV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchRequestPaymentV01( MessageIdentification1 reqMessageIdentification,AccountSwitchDetails1 reqAccountSwitchDetails,CashAccount36 reqOldAccount,CreditTransferTransaction27 reqCreditInstructions )
    {
        MessageIdentification = reqMessageIdentification;
        AccountSwitchDetails = reqAccountSwitchDetails;
        OldAccount = reqOldAccount;
        CreditInstructions = reqCreditInstructions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_I3wisa5kEee17eDA_q0a9g")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information about the details of the account switch and a response code to the original payment request.
    /// </summary>
    [IsoId("_KYA0ga5kEee17eDA_q0a9g")]
    [DisplayName("Account Switch Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSwtchDtls")]
    #endif
    [IsoXmlTag("AcctSwtchDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSwitchDetails1 AccountSwitchDetails { get; init; } 
    #else
    public AccountSwitchDetails1 AccountSwitchDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_XMcGgBMMEeSTk5fcu7tr9w")]
    [DisplayName("Old Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdAcct")]
    #endif
    [IsoXmlTag("OdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount36 OldAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount36 OldAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount36 OldAccount { get; init; } 
    #else
    public CashAccount36 OldAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.
    /// </summary>
    [IsoId("_kisvcF11EeeRXu-I2a3CBQ")]
    [DisplayName("Credit Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInstrs")]
    #endif
    [IsoXmlTag("CdtInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditTransferTransaction27 CreditInstructions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditTransferTransaction27 CreditInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransaction27 CreditInstructions { get; init; } 
    #else
    public CreditTransferTransaction27 CreditInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_g84jIA8EEeeJ4ZumUkzG4Q")]
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


// Since AccountSwitchRequestPaymentV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchRequestPaymentV01.

