// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further means of referencing a payment transaction.
/// </summary>
[IsoId("_QgGTU249EeiU9cctagi5ow")]
[DisplayName("Notification Item")]
public record NotificationItem7
{
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the expected credit entry.
    /// </summary>
    [IsoId("_Qpe4pW49EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the debtor, to unambiguously identify the underlying transaction to the creditor. |Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
    /// </summary>
    [IsoId("_Qpe4p249EeiU9cctagi5ow")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_Omx-4YkJEei-69PNFxn_Ew")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_Qpe4qW49EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount38? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Qpe4q249EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party40Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Qpe4rW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_Qpe4r249EeiU9cctagi5ow")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount38? RelatedAccount { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account.
    /// </summary>
    [IsoId("_Qpe4sW49EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account is expected to be credited.
    /// </summary>
    [IsoId("_Qpe4s249EeiU9cctagi5ow")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_Qpe4tW49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Qpe4t249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and the account servicer.|Usage: This is the agent from which the account servicer will get the amount of money. If there is more than one intermediary agent, then IntermediaryAgent identifies the agent closest to the account servicer.|IntermediaryAgent must only be included when different from the debtor agent.
    /// </summary>
    [IsoId("_Qpe4uW49EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_Qpe4u249EeiU9cctagi5ow")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_Qpe4vW49EeiU9cctagi5ow")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation7? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the reconciliation of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_Qpe4v249EeiU9cctagi5ow")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }
}
