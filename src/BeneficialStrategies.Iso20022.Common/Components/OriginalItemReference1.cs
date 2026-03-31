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
[IsoId("_QTA6gCeeEd-TZN8k_VGT2w")]
[DisplayName("Original Item Reference")]
public record OriginalItemReference1
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_QTdmcieeEd-TZN8k_VGT2w")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount16? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_QTnXcieeEd-TZN8k_VGT2w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party12Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_QTxIcieeEd-TZN8k_VGT2w")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_wPE7AGRFEd-H6JH3fJXmzQ")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount16? RelatedAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_QUNNUieeEd-TZN8k_VGT2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party12Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_uW3rQChEEd-EIr9rhewRTQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_knQyYChEEd-EIr9rhewRTQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_QUp5RSeeEd-TZN8k_VGT2w")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_OMCMYChNEd-EIr9rhewRTQ")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation2? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_QU9bQieeEd-TZN8k_VGT2w")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }
}
