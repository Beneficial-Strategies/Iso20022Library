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
/// This record is an implementation of the acmt.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to an account owner, eg, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Description(@"Scope|An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to an account owner, eg, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.|When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.")]
[IsoId("_o6y4K9E9Ed-BzquC8wXy7w_-1762172506")]
[DisplayName("Account Details Confirmation V")]
public partial record AccountDetailsConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConfV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.02";
    
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
    [IsoId("_o6y4LNE9Ed-BzquC8wXy7w_-1885939941")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_o68pINE9Ed-BzquC8wXy7w_203534418")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_o68pIdE9Ed-BzquC8wXy7w_-1762172463")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Provide detailed information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_o68pItE9Ed-BzquC8wXy7w_-1762172095")]
    [DisplayName("Confirmation Details")]
    [IsoXmlTag("ConfDtls")]
    public required AccountManagementConfirmation1 ConfirmationDetails { get; init; } 
    
    /// <summary>
    /// Confirmation of the information related to a selected investment account.
    /// </summary>
    [IsoId("_o68pI9E9Ed-BzquC8wXy7w_-1762172042")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount27? InvestmentAccount { get; init; } 
    
    /// <summary>
    /// Confirmation of information related to parties who are related to a selected investment account.
    /// </summary>
    [IsoId("_o68pJNE9Ed-BzquC8wXy7w_-1762171905")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public AccountParties5? AccountParties { get; init; } 
    
    /// <summary>
    /// Confirmation of information related to intermediaries who are related to a selected investment account.
    /// </summary>
    [IsoId("_o68pJdE9Ed-BzquC8wXy7w_-1762171845")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary12> Intermediaries { get; init; } = new ValueList<Intermediary12>(){};
    
    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_o68pJtE9Ed-BzquC8wXy7w_-1762171473")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent1? Placement { get; init; } 
    
    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_o7FzENE9Ed-BzquC8wXy7w_-1761251466")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation1? NewIssueAllocation { get; init; } 
    
    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o7FzEdE9Ed-BzquC8wXy7w_-1762171940")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan4> SavingsInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Confirmation of the information related to a withrawal plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o7FzEtE9Ed-BzquC8wXy7w_-1762172000")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan4> WithdrawalInvestmentPlan { get; init; } = new ValueList<InvestmentPlan4>(){};
    
    /// <summary>
    /// Confirmation of the cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_o7FzE9E9Ed-BzquC8wXy7w_-1762171568")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    public InvestmentFundCashSettlementInformation3? CashSettlement { get; init; } 
    
    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_o7FzFNE9Ed-BzquC8wXy7w_-1762171533")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend1> ServiceLevelAgreement { get; init; } = new ValueList<DocumentToSend1>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_o7FzFdE9Ed-BzquC8wXy7w_-1762172420")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountDetailsConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountDetailsConfirmationV02.

