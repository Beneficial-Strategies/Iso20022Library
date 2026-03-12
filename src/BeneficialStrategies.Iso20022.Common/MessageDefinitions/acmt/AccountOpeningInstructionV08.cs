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
/// This record is an implementation of the acmt.001.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountOpeningInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian or securities depository, to instruct the opening of an account or the opening of an account and the establishment of an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|The AccountOpeningInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian or securities depository, to instruct the opening of an account or the opening of an account and the establishment of an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("_jDZTkZDiEem7fvtoGpNpow")]
[DisplayName("Account Opening Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountOpeningInstructionV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.08";
    
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
    /// Constructs a AccountOpeningInstructionV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountOpeningInstructionV08( MessageIdentification1 reqMessageIdentification,InvestmentAccountOpening4 reqInstructionDetails,InvestmentAccount73 reqInvestmentAccount,AccountParties17 reqAccountParties )
    {
        MessageIdentification = reqMessageIdentification;
        InstructionDetails = reqInstructionDetails;
        InvestmentAccount = reqInvestmentAccount;
        AccountParties = reqAccountParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_jDZTl5DiEem7fvtoGpNpow")]
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
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_jDZTmZDiEem7fvtoGpNpow")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundOrder4? OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundOrder4? OrderReference { get; init; } 
    #else
    public InvestmentFundOrder4? OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_jDZTm5DiEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference13? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference13? PreviousReference { get; init; } 
    #else
    public AdditionalReference13? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the opening instruction.
    /// </summary>
    [IsoId("_jDZTnZDiEem7fvtoGpNpow")]
    [DisplayName("Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDtls")]
    #endif
    [IsoXmlTag("InstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOpening4 InstructionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOpening4 InstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOpening4 InstructionDetails { get; init; } 
    #else
    public InvestmentAccountOpening4 InstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the account to be opened.
    /// </summary>
    [IsoId("_jDZTn5DiEem7fvtoGpNpow")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount73 InvestmentAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount73 InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount73 InvestmentAccount { get; init; } 
    #else
    public InvestmentAccount73 InvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_jDZToZDiEem7fvtoGpNpow")]
    [DisplayName("Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPties")]
    #endif
    [IsoXmlTag("AcctPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountParties17 AccountParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountParties17 AccountParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties17 AccountParties { get; init; } 
    #else
    public AccountParties17 AccountParties { get; set; } 
    #endif
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_jDZTo5DiEem7fvtoGpNpow")]
    [DisplayName("Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmies")]
    #endif
    [IsoXmlTag("Intrmies")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary46? Intermediaries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary46? Intermediaries { get; init; } 
    #else
    public Intermediary46? Intermediaries { get; set; } 
    #endif
    
    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_jDZTpZDiEem7fvtoGpNpow")]
    [DisplayName("Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Plcmnt")]
    #endif
    [IsoXmlTag("Plcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredAgent3? Placement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredAgent3? Placement { get; init; } 
    #else
    public ReferredAgent3? Placement { get; set; } 
    #endif
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_jDZTp5DiEem7fvtoGpNpow")]
    [DisplayName("New Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewIsseAllcn")]
    #endif
    [IsoXmlTag("NewIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    #else
    public NewIssueAllocation2? NewIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_jDZTqZDiEem7fvtoGpNpow")]
    [DisplayName("Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan17> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan17>(){};
    
    /// <summary>
    /// Plan through which holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_jDZTq5DiEem7fvtoGpNpow")]
    [DisplayName("Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan17> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan17>(){};
    
    /// <summary>
    /// Cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_jDZTrZDiEem7fvtoGpNpow")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement3> CashSettlement { get; init; } = new ValueList<CashSettlement3>(){};
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_jDZTr5DiEem7fvtoGpNpow")]
    [DisplayName("Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmt")]
    #endif
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend4> ServiceLevelAgreement { get; init; } = new ValueList<DocumentToSend4>(){};
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the account management activity and or any limitations and restrictions.
    /// </summary>
    [IsoId("_jDZTsZDiEem7fvtoGpNpow")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditiononalInformation13? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditiononalInformation13? AdditionalInformation { get; init; } 
    #else
    public AdditiononalInformation13? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_jDZTs5DiEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcVrsn")]
    #endif
    [IsoXmlTag("MktPrctcVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jDZTtZDiEem7fvtoGpNpow")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountOpeningInstructionV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningInstructionV08.

