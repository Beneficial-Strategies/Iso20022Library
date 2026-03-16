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
[IsoId("_bsmTwdcZEeqRFcf2R4bPBw")]
[DisplayName("Charges")]
public record Charges9
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_buLBEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_buLBE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the agent to which a credit entry will be made as a result of the charges.
    /// </summary>
    [IsoId("_buLBFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Agent Account")]
    [IsoXmlTag("AgtAcct")]
    public CashAccount40? AgentAccount { get; init; }
}
