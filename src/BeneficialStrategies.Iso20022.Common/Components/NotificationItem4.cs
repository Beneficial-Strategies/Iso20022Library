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
[IsoId("_s_075FkyEeGeoaLUQk__nA_287447596")]
[DisplayName("Notification Item")]
public record NotificationItem4
{
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the expected credit entry.
    /// </summary>
    [IsoId("_s_-F0FkyEeGeoaLUQk__nA_-722313353")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the debtor, to unambiguously identify the underlying transaction to the creditor. |Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
    /// </summary>
    [IsoId("_s_-F0VkyEeGeoaLUQk__nA_-619127387")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_tAH20FkyEeGeoaLUQk__nA_-630226164")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount24? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tAH20VkyEeGeoaLUQk__nA_1511327927")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party12Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tAaxwFkyEeGeoaLUQk__nA_-616499916")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_tAaxwVkyEeGeoaLUQk__nA_-498628931")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account.
    /// </summary>
    [IsoId("_tAaxwlkyEeGeoaLUQk__nA_-351630096")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account is expected to be credited.
    /// </summary>
    [IsoId("_tAaxw1kyEeGeoaLUQk__nA_1323436045")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_tAaxxFkyEeGeoaLUQk__nA_122871774")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party12Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_tAkiwFkyEeGeoaLUQk__nA_111772997")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and the account servicer.|Usage: This is the agent from which the account servicer will get the amount of money. If there is more than one intermediary agent, then IntermediaryAgent identifies the agent closest to the account servicer.|IntermediaryAgent must only be included when different from the debtor agent.
    /// </summary>
    [IsoId("_tAkiwVkyEeGeoaLUQk__nA_1539369071")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_tAkiwlkyEeGeoaLUQk__nA_1221592410")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_tAkiw1kyEeGeoaLUQk__nA_-1785613790")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation2? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the reconciliation of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_tAkixFkyEeGeoaLUQk__nA_-1083357989")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
