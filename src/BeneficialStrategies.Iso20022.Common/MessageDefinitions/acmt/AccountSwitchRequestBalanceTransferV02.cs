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
/// This record is an implementation of the acmt.031.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer. 
/// </summary>
[Description(@"The AccountSwitchRequestBalanceTransfer message is sent by the new account servicer to the account servicer which previously held the account to request the transfer of the closing balance. This may be addressed to the new account or an alternate account nominated by the new account servicer. ")]
[IsoId("_7HT_aW42EeiU9cctagi5ow")]
[DisplayName("Account Switch Request Balance Transfer V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchRequestBalanceTransferV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.031.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqBalTrf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.031.001.02";
    
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
    /// Constructs a AccountSwitchRequestBalanceTransferV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchRequestBalanceTransferV02( MessageIdentification1 reqMessageIdentification,AccountSwitchDetails1 reqAccountSwitchDetails,CashAccount39 reqNewAccount )
    {
        MessageIdentification = reqMessageIdentification;
        AccountSwitchDetails = reqAccountSwitchDetails;
        NewAccount = reqNewAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HT_a242EeiU9cctagi5ow")]
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
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_7HT_bW42EeiU9cctagi5ow")]
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
    /// Details of the new account set up with the new account servicer.
    /// Usage: If an Alternate Credit Account is not specified and the closing balance of the old account was positive then the payment of the outstanding balance should be made to this account.
    /// </summary>
    [IsoId("_7HT_b242EeiU9cctagi5ow")]
    [DisplayName("New Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAcct")]
    #endif
    [IsoXmlTag("NewAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount39 NewAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount39 NewAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount39 NewAccount { get; init; } 
    #else
    public CashAccount39 NewAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate beneficiary account for a payment made from the old account servicer to the new account servicer in the case of a positive closing balance of the old bank.
    /// </summary>
    [IsoId("_7HT_cW42EeiU9cctagi5ow")]
    [DisplayName("Nominated Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmntdAcct")]
    #endif
    [IsoXmlTag("NmntdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount39? NominatedAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount39? NominatedAccount { get; init; } 
    #else
    public CashAccount39? NominatedAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information that enables the receiving bank to reconcile the payment with the request.
    /// </summary>
    [IsoId("_7HT_c242EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrf")]
    #endif
    [IsoXmlTag("BalTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceTransfer2? BalanceTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceTransfer2? BalanceTransfer { get; init; } 
    #else
    public BalanceTransfer2? BalanceTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HT_dW42EeiU9cctagi5ow")]
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


// Since AccountSwitchRequestBalanceTransferV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchRequestBalanceTransferV02.

