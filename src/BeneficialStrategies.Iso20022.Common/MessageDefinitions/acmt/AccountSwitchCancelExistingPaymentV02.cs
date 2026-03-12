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
/// This record is an implementation of the acmt.029.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner&apos;s account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. 
/// </summary>
[Description(@"The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner's account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. ")]
[IsoId("_7HK1f242EeiU9cctagi5ow")]
[DisplayName("Account Switch Cancel Existing Payment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSwitchCancelExistingPaymentV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.029.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchCclExstgPmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.029.001.02";
    
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
    /// Constructs a AccountSwitchCancelExistingPaymentV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSwitchCancelExistingPaymentV02( MessageIdentification1 reqMessageIdentification,AccountSwitchDetails1 reqAccountSwitchDetails,CashAccount39 reqOldAccount )
    {
        MessageIdentification = reqMessageIdentification;
        AccountSwitchDetails = reqAccountSwitchDetails;
        OldAccount = reqOldAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HK1gW42EeiU9cctagi5ow")]
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
    [IsoId("_7HK1g242EeiU9cctagi5ow")]
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
    /// Details of the old account.
    /// </summary>
    [IsoId("_7HK1hW42EeiU9cctagi5ow")]
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
    /// Details of a debit payment arrangement associated with the old account. The payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_7HK1h242EeiU9cctagi5ow")]
    [DisplayName("Payment Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstr")]
    #endif
    [IsoXmlTag("PmtInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstruction28? PaymentInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstruction28? PaymentInstruction { get; init; } 
    #else
    public PaymentInstruction28? PaymentInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a direct debit Instruction associated with the old account.
    /// </summary>
    [IsoId("_7HK1iW42EeiU9cctagi5ow")]
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
    [IsoId("_7HK1i242EeiU9cctagi5ow")]
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


// Since AccountSwitchCancelExistingPaymentV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchCancelExistingPaymentV02.

