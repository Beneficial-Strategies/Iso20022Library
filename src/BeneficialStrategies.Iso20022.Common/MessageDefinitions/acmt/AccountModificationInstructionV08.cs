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



namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.003.001.08 ISO standard message type.
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
[IsoId("_nayxoZDiEem7fvtoGpNpow")]
[DisplayName("Account Modification Instruction V")]
public partial record AccountModificationInstructionV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.003.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctModInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.003.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_nayxpZDiEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_nayxp5DiEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference13? PreviousReference { get; init; } 
    
    /// <summary>
    /// Information about the modification instruction.
    /// </summary>
    [IsoId("_nayxqZDiEem7fvtoGpNpow")]
    [DisplayName("Instruction Details")]
    [IsoXmlTag("InstrDtls")]
    public InvestmentAccountModification4? InstructionDetails { get; init; } 
    
    /// <summary>
    /// Identifies the account for which the information is modified.
    /// </summary>
    [IsoId("_nayxq5DiEem7fvtoGpNpow")]
    [DisplayName("Investment Account Selection")]
    [IsoXmlTag("InvstmtAcctSelctn")]
    public required AccountSelection3Choice_ InvestmentAccountSelection { get; init; } 
    
    /// <summary>
    /// Information related to general characteristics of the account to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxrZDiEem7fvtoGpNpow")]
    [DisplayName("Modified Investment Account")]
    [IsoXmlTag("ModfdInvstmtAcct")]
    public InvestmentAccount75? ModifiedInvestmentAccount { get; init; } 
    
    /// <summary>
    /// Information related to an account party to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxr5DiEem7fvtoGpNpow")]
    [DisplayName("Modified Account Parties")]
    [IsoXmlTag("ModfdAcctPties")]
    public AccountParties18? ModifiedAccountParties { get; init; } 
    
    /// <summary>
    /// Information related to intermediaries to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxsZDiEem7fvtoGpNpow")]
    [DisplayName("Modified Intermediaries")]
    [IsoXmlTag("ModfdIntrmies")]
    public ModificationScope40? ModifiedIntermediaries { get; init; } 
    
    /// <summary>
    /// Information related to referral information to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxs5DiEem7fvtoGpNpow")]
    [DisplayName("Modified Placement")]
    [IsoXmlTag("ModfdPlcmnt")]
    public ModificationScope43? ModifiedPlacement { get; init; } 
    
    /// <summary>
    /// Eligibility conditions related to allocation of new issues to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxtZDiEem7fvtoGpNpow")]
    [DisplayName("Modified Issue Allocation")]
    [IsoXmlTag("ModfdIsseAllcn")]
    public ModificationScope21? ModifiedIssueAllocation { get; init; } 
    
    /// <summary>
    /// Information related to a savings plan to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxt5DiEem7fvtoGpNpow")]
    [DisplayName("Modified Savings Investment Plan")]
    [IsoXmlTag("ModfdSvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<ModificationScope41> ModifiedSavingsInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Information related to a withdrawal plan to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_nayxuZDiEem7fvtoGpNpow")]
    [DisplayName("Modified Withdrawal Investment Plan")]
    [IsoXmlTag("ModfdWdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope41> ModifiedWithdrawalInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Cash settlement standing instruction to be either inserted or deleted.
    /// </summary>
    [IsoId("_nayxu5DiEem7fvtoGpNpow")]
    [DisplayName("Modified Cash Settlement")]
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement4> ModifiedCashSettlement { get; init; } = [];
    
    /// <summary>
    /// Information related to documents to be added, deleted or updated.
    /// </summary>
    [IsoId("_nayxvZDiEem7fvtoGpNpow")]
    [DisplayName("Modified Service Level Agreement")]
    [IsoXmlTag("ModfdSvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<ModificationScope44> ModifiedServiceLevelAgreement { get; init; } = [];
    
    /// <summary>
    /// Information related to additional information to be added, deleted or updated.
    /// </summary>
    [IsoId("_nayxv5DiEem7fvtoGpNpow")]
    [DisplayName("Modified Additional Information")]
    [IsoXmlTag("ModfdAddtlInf")]
    public ModificationScope45? ModifiedAdditionalInformation { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_nayxwZDiEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_nayxw5DiEem7fvtoGpNpow")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountModificationInstructionV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountModificationInstructionV08.

