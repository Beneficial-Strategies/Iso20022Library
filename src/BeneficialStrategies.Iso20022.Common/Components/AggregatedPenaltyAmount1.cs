// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated penalties amounts.
/// </summary>
[IsoId("_79hU8DmlEemla4muNfgRrg")]
[DisplayName("Aggregated Penalty Amount1")]
public record AggregatedPenaltyAmount1
{
    /// <summary>
    /// Sum of all debit amounts.
    /// </summary>
    [IsoId("_BO4g4zmmEemla4muNfgRrg")]
    [DisplayName("Aggregated Debit Amount")]
    [IsoXmlTag("AggtdDbtAmt")]
    public ActiveCurrencyAndAmount? AggregatedDebitAmount { get; init; }

    /// <summary>
    /// Sum of all credit amounts.
    /// </summary>
    [IsoId("_BO4g5DmmEemla4muNfgRrg")]
    [DisplayName("Aggregated Credit Amount")]
    [IsoXmlTag("AggtdCdtAmt")]
    public ActiveCurrencyAndAmount? AggregatedCreditAmount { get; init; }

    /// <summary>
    /// Net of all amounts.
    /// </summary>
    [IsoId("_vCmsEmHFEemrM9-N4eJYkA")]
    [DisplayName("Global Net Amount")]
    [IsoXmlTag("GblNetAmt")]
    public AmountAndDirection5? GlobalNetAmount { get; init; }

    /// <summary>
    /// Aggregated amounts provided per CSD of the counterparty.
    /// </summary>
    [IsoId("_BO4g5TmmEemla4muNfgRrg")]
    [DisplayName("Counterparty CSD Aggregated Amount")]
    [IsoXmlTag("CtrPtyCSDAggtdAmt")]
    public ValueList<AggregatedPenaltyAmount2> CounterpartyCSDAggregatedAmount { get; init; } = [];
}
