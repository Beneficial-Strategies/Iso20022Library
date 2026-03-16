// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the account notification.
/// </summary>
[IsoId("_03T4gTq4EeWZFYSPlduMhw")]
[DisplayName("Original Notification Reference")]
public record OriginalNotificationReference7
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_0-dpfTq4EeWZFYSPlduMhw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount24? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_0-dpfzq4EeWZFYSPlduMhw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party12Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_0-dpgTq4EeWZFYSPlduMhw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_0-dpgzq4EeWZFYSPlduMhw")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the Item entries.
    /// </summary>
    [IsoId("_0-dphTq4EeWZFYSPlduMhw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_0-dphzq4EeWZFYSPlduMhw")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_0-dpiTq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party12Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_0-dpizq4EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_0-dpjTq4EeWZFYSPlduMhw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("_0-dpjzq4EeWZFYSPlduMhw")]
    [DisplayName("Original Item And Status")]
    [IsoXmlTag("OrgnlItmAndSts")]
    public ValueList<OriginalItemAndStatus5> OriginalItemAndStatus { get; init; } = [];
    // ID for the above is _0-dpjzq4EeWZFYSPlduMhw
}
