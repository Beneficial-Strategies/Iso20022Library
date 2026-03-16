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
[IsoId("_pg0Qk8QHEemsic1bQcEtLA")]
[DisplayName("Compensation")]
public record Compensation3
{
    /// <summary>
    /// Amount of money to be paid in compensation.
    /// </summary>
    [IsoId("_pr10wcQHEemsic1bQcEtLA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// Usage: The debtor agent is the payer of the compensation amount.
    /// </summary>
    [IsoId("_pr10w8QHEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_sII4EsQHEemsic1bQcEtLA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// Usage: The creditor agent is the payee of the compensation amount.
    /// </summary>
    [IsoId("_pr10xcQHEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_sII4E8QHEemsic1bQcEtLA")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Reason for the payment compensation.
    /// </summary>
    [IsoId("_pr10x8QHEemsic1bQcEtLA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CompensationReason1Choice_ Reason { get; init; }
}
