// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.002.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.
/// Usage
/// The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.
/// When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.
/// When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message.
/// </summary>
[Description(
    @"Scope|An account servicer, for example, a registrar, transfer agent or custodian bank sends the AccountDetailsConfirmation message to the account owner, for example, an investor to confirm the opening of an investment fund account, execution of an AccountModificationInstruction or to return information requested in a GetAccountDetails message.|Usage|The AccountDetailsConfirmation message is used to confirm the opening of an account, modification of an account or the provision of information requested in a previously sent GetAccountDetails message. The message contains detailed information relevant to the opened account.|When the AccountDetailsConfirmation is used to confirm execution of an AccountModificationInstruction message, it contains the modified subsets of account details that were specified in the AccountModificationInstruction.|When the AccountDetailsConfirmation is used to reply to a GetAccountDetails message, it returns the selected subsets of account details that were specified in the GetAccountDetails message."
)]
[IsoId("_o6vjsQgpEeSUG-8hqXsVMQ")]
[DisplayName("Account Details Confirmation V")]
public record AccountDetailsConfirmationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.002.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctDtlsConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.002.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_o6vjwwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identifies a related order.
    /// </summary>
    [IsoId("_o6vjxQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_o6vjxwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Provides detailed information about the request or instruction which triggered this confirmation.
    /// </summary>
    [IsoId("_o6vjyQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Confirmation Details")]
    [IsoXmlTag("ConfDtls")]
    public required AccountManagementConfirmation2 ConfirmationDetails { get; init; }

    /// <summary>
    /// Confirmation of the information related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjywgpEeSUG-8hqXsVMQ")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount46? InvestmentAccount { get; init; }

    /// <summary>
    /// Confirmation of information related to parties who are related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjzQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public AccountParties12? AccountParties { get; init; }

    /// <summary>
    /// Confirmation of information related to intermediaries who are related to a selected investment account.
    /// </summary>
    [IsoId("_o6vjzwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary24> Intermediaries { get; init; } = [];

    /// <summary>
    /// Placement agent for the hedge fund industry.
    /// </summary>
    [IsoId("_o6vj0QgpEeSUG-8hqXsVMQ")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent1? Placement { get; init; }

    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_o6vj0wgpEeSUG-8hqXsVMQ")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; }

    /// <summary>
    /// Confirmation of the information related to a savings plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o6vj1QgpEeSUG-8hqXsVMQ")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan10> SavingsInvestmentPlan { get; init; } = [];

    /// <summary>
    /// Confirmation of the information related to a withdrawal plan that is related to a selected investment account.
    /// </summary>
    [IsoId("_o6vj1wgpEeSUG-8hqXsVMQ")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan10> WithdrawalInvestmentPlan { get; init; } = [];

    /// <summary>
    /// Confirmation of the cash settlement standing instruction associated to the investment fund transaction.
    /// </summary>
    [IsoId("_o6vj2QgpEeSUG-8hqXsVMQ")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation7> CashSettlement { get; init; } = [];

    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_o6vj2wgpEeSUG-8hqXsVMQ")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend2> ServiceLevelAgreement { get; init; } = [];

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_o6vj3QgpEeSUG-8hqXsVMQ")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_o6vj3wgpEeSUG-8hqXsVMQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountDetailsConfirmationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountDetailsConfirmationV05.
