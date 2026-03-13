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
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_jDZTl5DiEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_jDZTmZDiEem7fvtoGpNpow")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_jDZTm5DiEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference13? PreviousReference { get; init; } 
    
    /// <summary>
    /// Information about the opening instruction.
    /// </summary>
    [IsoId("_jDZTnZDiEem7fvtoGpNpow")]
    [DisplayName("Instruction Details")]
    [IsoXmlTag("InstrDtls")]
    public required InvestmentAccountOpening4 InstructionDetails { get; init; } 
    
    /// <summary>
    /// Detailed information about the account to be opened.
    /// </summary>
    [IsoId("_jDZTn5DiEem7fvtoGpNpow")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public required InvestmentAccount73 InvestmentAccount { get; init; } 
    
    /// <summary>
    /// Information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_jDZToZDiEem7fvtoGpNpow")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public required AccountParties17 AccountParties { get; init; } 
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_jDZTo5DiEem7fvtoGpNpow")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    public Intermediary46? Intermediaries { get; init; } 
    
    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_jDZTpZDiEem7fvtoGpNpow")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent3? Placement { get; init; } 
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_jDZTp5DiEem7fvtoGpNpow")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_jDZTqZDiEem7fvtoGpNpow")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan17> SavingsInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Plan through which holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_jDZTq5DiEem7fvtoGpNpow")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan17> WithdrawalInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_jDZTrZDiEem7fvtoGpNpow")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement3> CashSettlement { get; init; } = [];
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_jDZTr5DiEem7fvtoGpNpow")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend4> ServiceLevelAgreement { get; init; } = [];
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the account management activity and or any limitations and restrictions.
    /// </summary>
    [IsoId("_jDZTsZDiEem7fvtoGpNpow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditiononalInformation13? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_jDZTs5DiEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jDZTtZDiEem7fvtoGpNpow")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountOpeningInstructionV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningInstructionV08.

