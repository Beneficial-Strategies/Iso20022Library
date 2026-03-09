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
/// This record is an implementation of the acmt.027.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchInformationRequest message is sent by the new account servicer to the account servicer which previously held the account to initiate the account switch process. It provides information sufficient for the old account servicer to identify the old account and validate the account parties. The new account servicer is able to inform the old bank of the maximum funding the new account will provide to settle a negative closing balance and the proposed balance transfer window.
/// </summary>
[Description(@"The AccountSwitchInformationRequest message is sent by the new account servicer to the account servicer which previously held the account to initiate the account switch process. It provides information sufficient for the old account servicer to identify the old account and validate the account parties. The new account servicer is able to inform the old bank of the maximum funding the new account will provide to settle a negative closing balance and the proposed balance transfer window.")]
[IsoId("_7HK1jW42EeiU9cctagi5ow")]
[DisplayName("Account Switch Information Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchInformationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.027.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.027.001.02";
    
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
    /// Constructs a AccountSwitchInformationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchInformationRequestV02( MessageIdentification1 reqMessageIdentification,AccountSwitchDetails1 reqAccountSwitchDetails,NewAccount2 reqNewAccount,CashAccount39 reqOldAccount )
    {
        MessageIdentification = reqMessageIdentification;
        AccountSwitchDetails = reqAccountSwitchDetails;
        NewAccount = reqNewAccount;
        OldAccount = reqOldAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HK1j242EeiU9cctagi5ow")]
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
    [IsoId("_7HK1kW42EeiU9cctagi5ow")]
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
    /// Account servicer holding the account to which the switch will be made. That is, the acquiring account servicer.
    /// </summary>
    [IsoId("_7HK1k242EeiU9cctagi5ow")]
    [DisplayName("New Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAcct")]
    #endif
    [IsoXmlTag("NewAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NewAccount2 NewAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NewAccount2 NewAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewAccount2 NewAccount { get; init; } 
    #else
    public NewAccount2 NewAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_7HK1lW42EeiU9cctagi5ow")]
    [DisplayName("Old Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdAcct")]
    #endif
    [IsoXmlTag("OdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount39 OldAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount39 OldAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount39 OldAccount { get; init; } 
    #else
    public CashAccount39 OldAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information that enables the receiving account servicer to reconcile the payment with the request.
    /// </summary>
    [IsoId("_7HK1l242EeiU9cctagi5ow")]
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
    [IsoId("_7HK1mW42EeiU9cctagi5ow")]
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


// Since AccountSwitchInformationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchInformationRequestV02.

