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
[IsoId("a20cda2a-a121-48de-a0bf-f1f92b322248")]
[DisplayName("Notification Item10")]
public record NotificationItem10
{
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the expected credit entry.
    /// </summary>
    [IsoId("eae303a5-0053-4761-929c-b0b1d0b41472")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the debtor, to unambiguously identify the underlying transaction to the creditor.
    /// </summary>
    [IsoId("ce864501-d56b-41b9-8720-d354a3613627")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("6ac0e6e3-9452-4317-baca-5f45853e9e15")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("b3c197f2-b654-49cf-9073-a566ffa40160")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("02ba562a-6451-415d-a5c6-9b13a1cac06c")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party50Choice? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner.
    /// </summary>
    [IsoId("e1464284-0de9-4760-a338-758ca3c7364d")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("99738741-780e-4a26-b90b-0732dffb4b35")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account.
    /// </summary>
    [IsoId("ee18ee59-230d-4461-950f-161d3d6a3656")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account is expected to be credited.
    /// </summary>
    [IsoId("c9df1ebc-c3a8-4831-b547-b986bb646982")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("a66147a5-5e62-4307-b8bd-512f902dd920")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party50Choice? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("0aa5294c-a7de-4283-9009-752d048db7af")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Agent between the debtor agent and the account servicer.
    /// </summary>
    [IsoId("8b15a992-e98a-4f1c-9e04-baf1f4379c48")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("846fceff-568a-449d-be07-1f094b0d9c6c")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("e13ac8a1-102b-4b21-afc8-055b00236d36")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation8? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the reconciliation of a payment with the items that the payment is intended to settle.
    /// </summary>
    [IsoId("75c81ece-59fa-4bd0-b7dd-e0423a059db2")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <summary>
    /// Provides information on the underlying allocations that make up the expected credit entry.
    /// </summary>
    [IsoId("55b983a5-72de-4d9b-9ac6-b9705d75c566")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    public ValueList<TransactionAllocation2> UnderlyingAllocation { get; init; } = [];
}
