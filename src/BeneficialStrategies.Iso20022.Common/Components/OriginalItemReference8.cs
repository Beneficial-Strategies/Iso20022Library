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
[IsoId("bf45fad0-cc41-4318-897a-87fe98f683d1")]
[DisplayName("Original Item Reference8")]
public record OriginalItemReference8
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("f454f512-f4de-4763-b9aa-f4a729cc5ede")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("e88bc3de-09d5-41d8-b19b-3497cdf1798f")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party50Choice? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("4bbccf60-3e00-43bd-b80d-cbeaa551d017")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("cb2aae36-f567-4cac-9531-c2ce513a8f3b")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount40? RelatedAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("fae69213-7200-4fd9-ab78-2572ef52a1c6")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party50Choice? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("bc3084b0-fe93-4573-b174-013bda0eaaa1")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("2586d1d6-8d99-4a52-9c21-784eb4e51f46")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("44390462-63d3-447d-b9dd-4c4bd2f1cd8c")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("7d74aa8d-e39c-464c-a96e-3791fce3f573")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation8? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("dc38241b-ff48-441e-a4a2-cdfb3d7962de")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }
}
