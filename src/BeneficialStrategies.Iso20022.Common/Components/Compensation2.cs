// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of a payment compensation.
/// </summary>
[IsoId("__HkEl249EeiU9cctagi5ow")]
[DisplayName("Compensation")]
public record Compensation2
{
    /// <summary>
    /// Amount of money to be paid in compensation.
    /// </summary>
    [IsoId("__RZWAW49EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// Usage: The debtor agent is the payer of the compensation amount.
    /// </summary>
    [IsoId("__RZWA249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// Usage: The creditor agent is the payee of the compensation amount.
    /// </summary>
    [IsoId("__RZWBW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <summary>
    /// Reason for the payment compensation.
    /// </summary>
    [IsoId("__RZWB249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CompensationReason1Choice_ Reason { get; init; }
}
