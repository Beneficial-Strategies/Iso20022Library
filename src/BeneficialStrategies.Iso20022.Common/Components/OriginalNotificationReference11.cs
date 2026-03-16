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
[IsoId("_b6SxjdcZEeqRFcf2R4bPBw")]
[DisplayName("Original Notification Reference")]
public record OriginalNotificationReference11
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_b72329cZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_b7233dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party40Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_b72339cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_b7234dcZEeqRFcf2R4bPBw")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the item entries.
    /// </summary>
    [IsoId("_b72349cZEeqRFcf2R4bPBw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_b7235dcZEeqRFcf2R4bPBw")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_b72359cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_b7236dcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_b72369cZEeqRFcf2R4bPBw")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("_b7237dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Item And Status")]
    [IsoXmlTag("OrgnlItmAndSts")]
    public ValueList<OriginalItemAndStatus7> OriginalItemAndStatus { get; init; } = [];
    // ID for the above is _b7237dcZEeqRFcf2R4bPBw
}
