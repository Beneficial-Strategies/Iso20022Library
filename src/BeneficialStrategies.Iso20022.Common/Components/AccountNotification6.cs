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
[IsoId("_tlra8lkyEeGeoaLUQk__nA_-1825023044")]
[DisplayName("Account Notification")]
public record AccountNotification6
{
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account notification.
    /// </summary>
    [IsoId("_tlra81kyEeGeoaLUQk__nA_1472871899")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_tl0k4FkyEeGeoaLUQk__nA_1707910104")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount24? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tl0k4VkyEeGeoaLUQk__nA_1302539750")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party12Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tl0k4lkyEeGeoaLUQk__nA_-1914407208")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_tl0k41kyEeGeoaLUQk__nA_-610656971")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount24? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the Item entries.
    /// </summary>
    [IsoId("_tl-V4FkyEeGeoaLUQk__nA_192484558")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("_tl-V4VkyEeGeoaLUQk__nA_719480501")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_tl-V4lkyEeGeoaLUQk__nA_359504453")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party12Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_tmIG4FkyEeGeoaLUQk__nA_1717315409")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
    /// </summary>
    [IsoId("_tmIG4VkyEeGeoaLUQk__nA_338632466")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("_tmIG4lkyEeGeoaLUQk__nA_1642382703")]
    [DisplayName("Item")]
    [IsoXmlTag("Itm")]
    public ValueList<NotificationItem4> Item { get; init; } = [];
    // ID for the above is _tmIG4lkyEeGeoaLUQk__nA_1642382703
}
