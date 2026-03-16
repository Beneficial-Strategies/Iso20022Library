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
/// This record is an implementation of the acmt.001.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent, custodian or securities depository to instruct the opening of an account or the opening of an account and the establishment of an investment plan.
/// Usage
/// The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.
/// In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.
/// Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message.
/// </summary>
[Description(
    @"Scope|An account owner, for example, an investor or its designated agent sends the AccountOpeningInstruction message to the account servicer, for example, a registrar, transfer agent, custodian or securities depository to instruct the opening of an account or the opening of an account and the establishment of an investment plan.|Usage|The AccountOpeningInstruction is used to open an account directly or indirectly with the account servicer or an intermediary.|In some markets, for example, Australia, and for some products in the United Kingdom, a first order (also known as a deposit instruction) is placed at the same time as the account opening. To cater for this scenario, an order message can be linked (via references in the message) to the AccountOpeningInstruction message when needed.|Execution of the AccountOpeningInstruction is confirmed via an AccountDetailsConfirmation message."
)]
[IsoId("_51Xr0R8KEeWpZde3LQh6dg")]
[DisplayName("Account Opening Instruction V")]
public record AccountOpeningInstructionV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.001.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.001.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_51Xr4x8KEeWpZde3LQh6dg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Identifies a related order or settlement transaction.
    /// </summary>
    [IsoId("_51Xr5R8KEeWpZde3LQh6dg")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    public InvestmentFundOrder4? OrderReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_51Xr5x8KEeWpZde3LQh6dg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }

    /// <summary>
    /// Information about the opening instruction.
    /// </summary>
    [IsoId("_51Xr6R8KEeWpZde3LQh6dg")]
    [DisplayName("Instruction Details")]
    [IsoXmlTag("InstrDtls")]
    public required InvestmentAccountOpening2 InstructionDetails { get; init; }

    /// <summary>
    /// Detailed information about the account to be opened.
    /// </summary>
    [IsoId("_51Xr6x8KEeWpZde3LQh6dg")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public required InvestmentAccount49 InvestmentAccount { get; init; }

    /// <summary>
    /// Information related to parties that are related to the account, for example, primary account owner.
    /// </summary>
    [IsoId("_51Xr7R8KEeWpZde3LQh6dg")]
    [DisplayName("Account Parties")]
    [IsoXmlTag("AcctPties")]
    public required AccountParties13 AccountParties { get; init; }

    /// <summary>
    /// Intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the &apos;account controller&apos;.
    /// </summary>
    [IsoId("_51Xr7x8KEeWpZde3LQh6dg")]
    [DisplayName("Intermediaries")]
    [IsoXmlTag("Intrmies")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary36> Intermediaries { get; init; } = [];

    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_51Xr8R8KEeWpZde3LQh6dg")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public ReferredAgent2? Placement { get; init; }

    /// <summary>
    /// Eligibility conditions applicable when there is an allocation of new issues for hedge fund account opening.
    /// </summary>
    [IsoId("_51Xr8x8KEeWpZde3LQh6dg")]
    [DisplayName("New Issue Allocation")]
    [IsoXmlTag("NewIsseAllcn")]
    public NewIssueAllocation2? NewIssueAllocation { get; init; }

    /// <summary>
    /// Plan that allows individuals to set aside a fixed amount of money at specified intervals, usually for a special purpose, for example, retirement.
    /// </summary>
    [IsoId("_51Xr9R8KEeWpZde3LQh6dg")]
    [DisplayName("Savings Investment Plan")]
    [IsoXmlTag("SvgsInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(50)]
    public ValueList<InvestmentPlan12> SavingsInvestmentPlan { get; init; } = [];

    /// <summary>
    /// Plan through which holdings are depleted through regular withdrawals at specified intervals.
    /// </summary>
    [IsoId("_51Xr9x8KEeWpZde3LQh6dg")]
    [DisplayName("Withdrawal Investment Plan")]
    [IsoXmlTag("WdrwlInvstmtPlan")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentPlan12> WithdrawalInvestmentPlan { get; init; } = [];

    /// <summary>
    /// Cash settlement standing instruction associated to transactions on the account.
    /// </summary>
    [IsoId("_51Xr-R8KEeWpZde3LQh6dg")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement1> CashSettlement { get; init; } = [];

    /// <summary>
    /// Identifies documents to be provided for the account opening.
    /// </summary>
    [IsoId("_51Xr-x8KEeWpZde3LQh6dg")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    [MinLength(0)]
    [MaxLength(30)]
    public ValueList<DocumentToSend3> ServiceLevelAgreement { get; init; } = [];

    /// <summary>
    /// Additional information concerning limitations and restrictions on the account.
    /// </summary>
    [IsoId("_6Md8ACFhEeW9XJWqfgXIIA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AccountRestrictions1? AdditionalInformation { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_51Xr_R8KEeWpZde3LQh6dg")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_51Xr_x8KEeWpZde3LQh6dg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountOpeningInstructionV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningInstructionV06.
