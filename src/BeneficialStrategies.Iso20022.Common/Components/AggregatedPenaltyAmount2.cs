// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated penalties amounts per party.
/// </summary>
[IsoId("_MwslMDkMEem897H7zB2RJg")]
[DisplayName("Aggregated Penalty Amount2")]
public record AggregatedPenaltyAmount2
{
    /// <summary>
    /// Unique and unambiguous identification of the party for which the aggregated amounts are referred to.
    /// </summary>
    [IsoId("_U61VEDkMEem897H7zB2RJg")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification136 PartyIdentification { get; init; }

    /// <summary>
    /// Sum of the debit amounts for the party.
    /// </summary>
    [IsoId("_iXrUsjkMEem897H7zB2RJg")]
    [DisplayName("Aggregated Debit Amount")]
    [IsoXmlTag("AggtdDbtAmt")]
    public ActiveCurrencyAndAmount? AggregatedDebitAmount { get; init; }

    /// <summary>
    /// Sum of the credit amounts for the party.
    /// </summary>
    [IsoId("_iXrUszkMEem897H7zB2RJg")]
    [DisplayName("Aggregated Credit Amount")]
    [IsoXmlTag("AggtdCdtAmt")]
    public ActiveCurrencyAndAmount? AggregatedCreditAmount { get; init; }

    /// <summary>
    /// Net of all amounts for this CSD.
    /// </summary>
    [IsoId("_18df0WHFEemrM9-N4eJYkA")]
    [DisplayName("Global Net Amount")]
    [IsoXmlTag("GblNetAmt")]
    public AmountAndDirection5? GlobalNetAmount { get; init; }
}
