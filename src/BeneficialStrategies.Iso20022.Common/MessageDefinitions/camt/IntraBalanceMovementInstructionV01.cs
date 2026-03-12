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
/// This record is an implementation of the camt.066.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementInstruction message is sent from an account owner/requestor to a settlement infrastructure to instruct the movement of an amount of money within its holdings from one sub-balance to another.
/// 
/// Usage: 
/// The message may be used to:
/// - re-send a message previously sent (the sub-function of the message is &quot;Duplicate&quot;)
/// - provide a third party with a copy of a message for information (the sub-function of the message is &quot;Copy&quot;)
/// - re-send to a third party a copy of a message for information (the sub-function of the message is &quot;CopyDuplicate&quot;).
/// </summary>
[Description(@"The IntraBalanceMovementInstruction message is sent from an account owner/requestor to a settlement infrastructure to instruct the movement of an amount of money within its holdings from one sub-balance to another.||Usage: |The message may be used to:|- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"").")]
[IsoId("_DLtKtTncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceMovementInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.066.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.066.001.01";
    
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
    /// Constructs a IntraBalanceMovementInstructionV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceMovementInstructionV01( CashAccount38 reqCashAccount,IntraBalance5 reqIntraBalance )
    {
        CashAccount = reqCashAccount;
        IntraBalance = reqIntraBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_DLtKvTncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAndDocumentIdentification6? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAndDocumentIdentification6? Identification { get; init; } 
    #else
    public TransactionAndDocumentIdentification6? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_DLtKvzncEem7JZMuWtwtsg")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Identification14? CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification14? CorporateActionEventIdentification { get; init; } 
    #else
    public Identification14? CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Count of the number of transactions linked.
    /// </summary>
    [IsoId("_DLtKwTncEem7JZMuWtwtsg")]
    [DisplayName("Number Counts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbCounts")]
    #endif
    [IsoXmlTag("NbCounts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberCount1Choice_? NumberCounts { get; init; } 
    #else
    public NumberCount1Choice_? NumberCounts { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_DLtKwzncEem7JZMuWtwtsg")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages57? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages57? Linkages { get; init; } 
    #else
    public Linkages57? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which an entry is made.
    /// </summary>
    [IsoId("_DLtKxTncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38 CashAccount { get; init; } 
    #else
    public CashAccount38 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_JXdhwjp7EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctOwnr")]
    #endif
    [IsoXmlTag("CshAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #else
    public SystemPartyIdentification8? CashAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_JXdhwzp7EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctSvcr")]
    #endif
    [IsoXmlTag("CshAcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Intra-balance movement transaction details.
    /// </summary>
    [IsoId("_DLtKxzncEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraBal")]
    #endif
    [IsoXmlTag("IntraBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraBalance5 IntraBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraBalance5 IntraBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalance5 IntraBalance { get; init; } 
    #else
    public IntraBalance5 IntraBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtKyTncEem7JZMuWtwtsg")]
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


// Since IntraBalanceMovementInstructionV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementInstructionV01.

