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
/// This record is an implementation of the acmt.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(@"Scope|An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent or custodian to instruct the opening of an account or the opening of an account and establishing an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.")]
[IsoId("_mVAQgQgpEeSUG-8hqXsVMQ")]
[DisplayName("Account Opening Instruction V")]
public partial record AccountOpeningInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.05";
    
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
    /// Identifies the message.
    /// </summary>
    [IsoId("_mVAQkwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_mVAQlQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_mVAQlwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Provides detailed information about the opening instruction.
    /// </summary>
    [IsoId("_mVAQmQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Instruction Details")]
    [IsoXmlTag("InstrDtls")]
    public required InvestmentAccountOpening1 InstructionDetails { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment account to be opened.
    /// </summary>
    [IsoId("_mVAQmwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public required InvestmentAccount37 InvestmentAccount { get; init; } 
    
    /// <summary>
    /// Information related to parties who are related to an investment account, for example, primary account owner.
    /// </summary>
    [IsoId("_mVAQnQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public required AccountParties10 AccountParties { get; init; } 
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_mVAQnwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary24> Intermediaries { get; init; } = [];
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_mVAQoQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent1? Placement { get; init; } 
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_mVAQowgpEeSUG-8hqXsVMQ")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    
    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_mVAQpQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan10> SavingsInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Plan through which an investment fund investor&apos;s holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_mVAQpwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan10> WithdrawalInvestmentPlan { get; init; } = [];
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_mVAQqQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation7> CashSettlement { get; init; } = [];
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_mVAQqwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend2> ServiceLevelAgreement { get; init; } = [];
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_mVAQrQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mVAQrwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountOpeningInstructionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningInstructionV05.

