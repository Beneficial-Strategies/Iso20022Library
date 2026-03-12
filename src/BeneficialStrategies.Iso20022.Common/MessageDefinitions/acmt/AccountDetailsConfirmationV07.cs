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
/// This record is an implementation of the acmt.002.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:
/// - contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or
/// - provide the status of the account.
/// When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. 
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Description(@"Scope|The AccountDetailsConfirmation message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner, for example, an investor to confirm the opening of an account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it may:|- contain the modified subsets of account details that were specified in the AccountModificationInstruction, and/or|- provide the status of the account.|When the AccountModificationInstruction message is used to instruct the closure of an account, the AccountDetailsConfirmation message is used to confirm the account has been closed. |When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
[IsoId("_7bHvcUNDEeaknIuOb43xYQ")]
[DisplayName("Account Details Confirmation V")]
public partial record AccountDetailsConfirmationV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.002.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.07";
    
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
    [IsoId("_7bHvd0NDEeaknIuOb43xYQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_7bHveUNDEeaknIuOb43xYQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_7bHve0NDEeaknIuOb43xYQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_7bHvfUNDEeaknIuOb43xYQ")]
    [DisplayName("Confirmation Details")]
    [IsoXmlTag("ConfDtls")]
    public required AccountManagementConfirmation4 ConfirmationDetails { get; init; } 
    
    /// <summary>
    /// Confirmation of the information related to the investment account.
    /// </summary>
    [IsoId("_7bHvf0NDEeaknIuOb43xYQ")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount62? InvestmentAccount { get; init; } 
    
    /// <summary>
    /// Confirmation of information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_7bHvgUNDEeaknIuOb43xYQ")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public AccountParties15? AccountParties { get; init; } 
    
    /// <summary>
    /// Confirmation of an intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_7bHvg0NDEeaknIuOb43xYQ")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary36> Intermediaries { get; init; } = new ValueList<Intermediary36>(){};
    
    /// <summary>
    /// Confirmation of referral information.
    /// </summary>
    [IsoId("_7bHvhUNDEeaknIuOb43xYQ")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent2? Placement { get; init; } 
    
    /// <summary>
    /// Confirmation of eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_7bHvh0NDEeaknIuOb43xYQ")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; } 
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to the account.
    /// </summary>
    [IsoId("_7bHviUNDEeaknIuOb43xYQ")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan14> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan14>(){};
    
    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to the account.
    /// </summary>
    [IsoId("_7bHvi0NDEeaknIuOb43xYQ")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan14> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan14>(){};
    
    /// <summary>
    /// Confirmation of a cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_7bHvjUNDEeaknIuOb43xYQ")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement1> CashSettlement { get; init; } = new ValueList<CashSettlement1>(){};
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_7bHvj0NDEeaknIuOb43xYQ")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend3> ServiceLevelAgreement { get; init; } = new ValueList<DocumentToSend3>(){};
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
    /// </summary>
    [IsoId("_7bHvkUNDEeaknIuOb43xYQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditiononalInformation12? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_7bHvk0NDEeaknIuOb43xYQ")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7bIWgUNDEeaknIuOb43xYQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountDetailsConfirmationV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountDetailsConfirmationV07.

