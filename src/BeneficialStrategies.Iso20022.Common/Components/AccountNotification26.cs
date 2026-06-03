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
[IsoId("4410df66-25fb-4c90-86bb-92526a3afa33")]
[DisplayName("Account Notification26")]
public record AccountNotification26
{
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account notification.
    /// </summary>
    [IsoId("bbc6a560-2035-4c00-aa48-ca013ab791e2")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("c69ec0b4-cdab-4568-bb3a-c2f8a6a2bdaa")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("a41469e2-6e65-4dc2-bc90-ebf869a7fbcc")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party50Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner.
    /// </summary>
    [IsoId("3b53dc43-a6a3-487a-92cd-7ec3a40746d5")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("1e43b21a-5500-4132-ac65-934a91e65277")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Sum of the amounts in all the Item entries.
    /// </summary>
    [IsoId("a3b4e056-1f2b-497e-a095-2eae60825de1")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    [IsoId("0a587bb5-287d-464e-8361-2cbc58cb9f4d")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("74bfe5dc-fe9a-4377-a9e9-1c2625a95556")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party50Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("0c393c2e-fd6c-4bcd-ab2b-a8f37bdb79d9")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    [IsoId("7ec366b7-5dba-4025-b714-fa03a46bedf4")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent { get; init; }

    /// <summary>
    /// Provides details of the expected amount on the account serviced by the account servicer.
    /// </summary>
    [IsoId("26611e4a-06dc-4581-9c0f-4ff09c4542f8")]
    [DisplayName("Item")]
    [IsoXmlTag("Itm")]
    [MinLength(1)]
    public ValueList<NotificationItem10> Item { get; init; } = [];
}
