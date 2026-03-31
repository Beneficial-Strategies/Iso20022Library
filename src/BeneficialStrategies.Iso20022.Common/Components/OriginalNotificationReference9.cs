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
[IsoId("_GYfxD249EeiU9cctagi5ow")]
[DisplayName("Original Notification Reference")]
public record OriginalNotificationReference9
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_GiezjW49EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount38? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Giezj249EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party40Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_GiezkW49EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_Giezk249EeiU9cctagi5ow")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount38? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the item entries.
    /// </summary>
    [IsoId("_GiezlW49EeiU9cctagi5ow")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_Giezl249EeiU9cctagi5ow")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_GiezmW49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Giezm249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_GieznW49EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("_Giezn249EeiU9cctagi5ow")]
    [DisplayName("Original Item And Status")]
    [IsoXmlTag("OrgnlItmAndSts")]
    public ValueList<OriginalItemAndStatus6> OriginalItemAndStatus { get; init; } = [];
    // ID for the above is _Giezn249EeiU9cctagi5ow
}
