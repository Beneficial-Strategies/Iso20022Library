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
/// This record is an implementation of the acmt.003.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountModificationInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to modify, that is, create, update or delete specific details of an existing account.
/// Usage
/// The AccountModificationInstruction message is used to modify the details of an existing account.
/// The AccountModificationInstruction message can be used to:
/// - maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,
/// - add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,
/// - delete specific account details, for example, delete cash standing instructions, or,
/// - instruct a change to the status of the account, for example, instruct the closure of the account.
/// The usage of this message may be subject to service level agreement (SLA) between the counterparties.
/// Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|The AccountModificationInstruction message is sent by an account owner, for example, an investor or its designated agent to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to modify, that is, create, update or delete specific details of an existing account.|Usage|The AccountModificationInstruction message is used to modify the details of an existing account.|The AccountModificationInstruction message can be used to:|- maintain/update any of the existing account details, for example, to update the address of the beneficiary or modify the preference to income from distribution to capitalisation, or,|- add/create specific details to the existing account when these details were not yet recorded at the time of account creation, for example, to add a second address or to establish new cash settlement standing instructions, or,|- delete specific account details, for example, delete cash standing instructions, or,|- instruct a change to the status of the account, for example, instruct the closure of the account.|The usage of this message may be subject to service level agreement (SLA) between the counterparties.|Execution of the AccountModificationInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("__kmtUUNDEeaknIuOb43xYQ")]
[DisplayName("Account Modification Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountModificationInstructionV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.07";
    
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
    /// Constructs a AccountModificationInstructionV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountModificationInstructionV07( MessageIdentification1 reqMessageIdentification,AccountSelection2Choice_ reqInvestmentAccountSelection )
    {
        MessageIdentification = reqMessageIdentification;
        InvestmentAccountSelection = reqInvestmentAccountSelection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("__kmtVUNDEeaknIuOb43xYQ")]
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
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("__kmtV0NDEeaknIuOb43xYQ")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference6? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference6? PreviousReference { get; init; } 
    #else
    public AdditionalReference6? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the modification instruction.
    /// </summary>
    [IsoId("__kmtWUNDEeaknIuOb43xYQ")]
    [DisplayName("Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDtls")]
    #endif
    [IsoXmlTag("InstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountModification3? InstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountModification3? InstructionDetails { get; init; } 
    #else
    public InvestmentAccountModification3? InstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account for which the information is modified.
    /// </summary>
    [IsoId("__kmtW0NDEeaknIuOb43xYQ")]
    [DisplayName("Investment Account Selection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctSelctn")]
    #endif
    [IsoXmlTag("InvstmtAcctSelctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountSelection2Choice_ InvestmentAccountSelection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountSelection2Choice_ InvestmentAccountSelection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSelection2Choice_ InvestmentAccountSelection { get; init; } 
    #else
    public AccountSelection2Choice_ InvestmentAccountSelection { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to general characteristics of the account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtXUNDEeaknIuOb43xYQ")]
    [DisplayName("Modified Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdInvstmtAcct")]
    #endif
    [IsoXmlTag("ModfdInvstmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount63? ModifiedInvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount63? ModifiedInvestmentAccount { get; init; } 
    #else
    public InvestmentAccount63? ModifiedInvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an account party to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtX0NDEeaknIuOb43xYQ")]
    [DisplayName("Modified Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdAcctPties")]
    #endif
    [IsoXmlTag("ModfdAcctPties")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<AccountParties16> ModifiedAccountParties { get; init; } = new ValueList<AccountParties16>(){};
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtYUNDEeaknIuOb43xYQ")]
    [DisplayName("Modified Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIntrmies")]
    #endif
    [IsoXmlTag("ModfdIntrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope38> ModifiedIntermediaries { get; init; } = new ValueList<ModificationScope38>(){};
    
    /// <summary>
    /// Information related to referral information to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtY0NDEeaknIuOb43xYQ")]
    [DisplayName("Modified Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdPlcmnt")]
    #endif
    [IsoXmlTag("ModfdPlcmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope33? ModifiedPlacement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope33? ModifiedPlacement { get; init; } 
    #else
    public ModificationScope33? ModifiedPlacement { get; set; } 
    #endif
    
    /// <summary>
    /// Eligibility conditions related to allocation of new issues to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtZUNDEeaknIuOb43xYQ")]
    [DisplayName("Modified Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdIsseAllcn")]
    #endif
    [IsoXmlTag("ModfdIsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope21? ModifiedIssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope21? ModifiedIssueAllocation { get; init; } 
    #else
    public ModificationScope21? ModifiedIssueAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to a savings plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtZ0NDEeaknIuOb43xYQ")]
    [DisplayName("Modified Savings Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvgsInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdSvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<ModificationScope37> ModifiedSavingsInvestmentPlan { get; init; } = new ValueList<ModificationScope37>(){};
    
    /// <summary>
    /// Information related to a withdrawal plan to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("__kmtaUNDEeaknIuOb43xYQ")]
    [DisplayName("Modified Withdrawal Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdWdrwlInvstmtPlan")]
    #endif
    [IsoXmlTag("ModfdWdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope37> ModifiedWithdrawalInvestmentPlan { get; init; } = new ValueList<ModificationScope37>(){};
    
    /// <summary>
    /// Cash settlement standing instruction to be either inserted or deleted.
    /// </summary>
    [IsoId("__kmta0NDEeaknIuOb43xYQ")]
    [DisplayName("Modified Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdCshSttlm")]
    #endif
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement2> ModifiedCashSettlement { get; init; } = new ValueList<CashSettlement2>(){};
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.|.
    /// </summary>
    [IsoId("__kmtbUNDEeaknIuOb43xYQ")]
    [DisplayName("Modified Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdSvcLvlAgrmt")]
    #endif
    [IsoXmlTag("ModfdSvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<ModificationScope31> ModifiedServiceLevelAgreement { get; init; } = new ValueList<ModificationScope31>(){};
    
    /// <summary>
    /// Information related to additional information to be added, deleted or updated.
    /// </summary>
    [IsoId("__kmtb0NDEeaknIuOb43xYQ")]
    [DisplayName("Modified Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdAddtlInf")]
    #endif
    [IsoXmlTag("ModfdAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationScope35? ModifiedAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationScope35? ModifiedAdditionalInformation { get; init; } 
    #else
    public ModificationScope35? ModifiedAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("__kmtcUNDEeaknIuOb43xYQ")]
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
    [IsoId("__kmtc0NDEeaknIuOb43xYQ")]
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


// Since AccountModificationInstructionV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountModificationInstructionV07.

