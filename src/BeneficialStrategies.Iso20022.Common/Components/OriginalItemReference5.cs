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
[IsoId("_Gxh8IW49EeiU9cctagi5ow")]
[DisplayName("Original Item Reference")]
public record OriginalItemReference5
{
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_G-CuE249EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount38? Account { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_G-CuFW49EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public Party40Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_G-CuF249EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }

    /// <summary>
    /// Identifies the parent account of the account to be credited with the incoming amount of money.
    /// </summary>
    [IsoId("_G-CuGW49EeiU9cctagi5ow")]
    [DisplayName("Related Account")]
    [IsoXmlTag("RltdAcct")]
    public CashAccount38? RelatedAccount { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_G-CuG249EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_G-CuHW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_G-CuH249EeiU9cctagi5ow")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_G-CuIW49EeiU9cctagi5ow")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    [IsoId("_G-CuI249EeiU9cctagi5ow")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    public RemittanceLocation7? RelatedRemittanceInformation { get; init; }

    /// <summary>
    /// Structured information that enables the matching, that is reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_G-CuJW49EeiU9cctagi5ow")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }
}
