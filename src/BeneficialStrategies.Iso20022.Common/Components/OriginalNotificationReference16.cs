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
[IsoId("8796e8f3-423b-409e-b91d-b8099813928d")]
[DisplayName("Original Notification Reference16")]
public record OriginalNotificationReference16
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("25b758a8-d529-40c3-829e-01f451abc9ab")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("4f6f198c-76cc-4919-967c-aa5f982bb642")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party50Choice? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("e86b95d7-1a61-4895-960a-359ac13287f3")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("5299a039-a46d-4f27-879d-41a000e1fa47")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the Item entries.
    /// </summary>
    [IsoId("3358084f-10d4-4f04-91bd-d490a736aa6f")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("db9a233e-172d-416d-b23d-8cd5698ef3f5")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("b305ea63-14e6-499c-a94c-aa68892045d4")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party50Choice? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("af6d6759-2ff3-476a-b8a1-fca049faea45")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("a0331b4b-38e3-498b-b314-25172f16e44f")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("9814e0e6-492f-4c43-ac3a-dd93caa73f3a")]
    [DisplayName("Original Item")]
    [IsoXmlTag("OrgnlItm")]
    [MinLength(1)]
    public ValueList<OriginalItem9> OriginalItem { get; init; } = [];
}
