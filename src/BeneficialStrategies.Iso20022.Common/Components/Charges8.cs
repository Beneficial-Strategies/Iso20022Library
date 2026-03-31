// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
[IsoId("_h-cOwcQIEemsic1bQcEtLA")]
[DisplayName("Charges")]
public record Charges8
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_iKDo48QIEemsic1bQcEtLA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_iKDo5cQIEemsic1bQcEtLA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the agent to which a credit entry will be made as a result of the charges.
    /// </summary>
    [IsoId("_j2sJ0cQIEemsic1bQcEtLA")]
    [DisplayName("Agent Account")]
    [IsoXmlTag("AgtAcct")]
    public CashAccount38? AgentAccount { get; init; }
}
