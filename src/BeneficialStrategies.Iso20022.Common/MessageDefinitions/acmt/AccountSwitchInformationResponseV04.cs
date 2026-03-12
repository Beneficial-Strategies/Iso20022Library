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
/// This record is an implementation of the acmt.028.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner&apos;s account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.
/// </summary>
[Description(@"The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner's account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.")]
[IsoId("_KOk_v9cDEeq_l4BJLVUF2Q")]
[DisplayName("Account Switch Information Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchInformationResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.028.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.028.001.04";
    
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
    /// Constructs a AccountSwitchInformationResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchInformationResponseV04( MessageIdentification1 reqMessageIdentification,AccountSwitchDetails1 reqAccountSwitchDetails,CashAccount41 reqNewAccount,CashAccount41 reqOldAccount )
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
    [IsoId("_KOk_wdcDEeq_l4BJLVUF2Q")]
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
    [IsoId("_KOk_w9cDEeq_l4BJLVUF2Q")]
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
    /// New account to which the switch will be made (destination account).
    /// </summary>
    [IsoId("_KOk_xdcDEeq_l4BJLVUF2Q")]
    [DisplayName("New Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewAcct")]
    #endif
    [IsoXmlTag("NewAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount41 NewAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount41 NewAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount41 NewAccount { get; init; } 
    #else
    public CashAccount41 NewAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_KOk_x9cDEeq_l4BJLVUF2Q")]
    [DisplayName("Old Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdAcct")]
    #endif
    [IsoXmlTag("OdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount41 OldAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount41 OldAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount41 OldAccount { get; init; } 
    #else
    public CashAccount41 OldAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of debit payment arrangements associated with the old account. For example the payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_KOk_ydcDEeq_l4BJLVUF2Q")]
    [DisplayName("Payment Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstr")]
    #endif
    [IsoXmlTag("PmtInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstruction38? PaymentInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstruction38? PaymentInstruction { get; init; } 
    #else
    public PaymentInstruction38? PaymentInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a direct debit instruction associated with the old account.
    /// </summary>
    [IsoId("_KOk_y9cDEeq_l4BJLVUF2Q")]
    [DisplayName("Direct Debit Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtInstr")]
    #endif
    [IsoXmlTag("DrctDbtInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DirectDebitInstructionDetails2? DirectDebitInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DirectDebitInstructionDetails2? DirectDebitInstruction { get; init; } 
    #else
    public DirectDebitInstructionDetails2? DirectDebitInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KOk_zdcDEeq_l4BJLVUF2Q")]
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


// Since AccountSwitchInformationResponseV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchInformationResponseV04.

