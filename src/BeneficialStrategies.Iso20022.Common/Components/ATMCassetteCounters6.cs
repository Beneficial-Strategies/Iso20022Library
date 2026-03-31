// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Cassette Counters6.
/// </summary>
[IsoId("_a2OAYaDmEe-MRKYsaX6JDg")]
[DisplayName("ATM Cassette Counters6")]
public record ATMCassetteCounters6
{
    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Current Amount.
    /// </summary>
    [DisplayName("Current Amount")]
    [IsoXmlTag("CurAmt")]
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; }

    /// <summary>
    /// Current Number.
    /// </summary>
    [DisplayName("Current Number")]
    [IsoXmlTag("CurNb")]
    public required IsoNumber CurrentNumber { get; init; }

    /// <summary>
    /// Flow Totals.
    /// </summary>
    [DisplayName("Flow Totals")]
    [IsoXmlTag("FlowTtls")]
    public ValueList<ATMCassetteCounters5> FlowTotals { get; init; } = [];

    /// <summary>
    /// Initial Count.
    /// </summary>
    [DisplayName("Initial Count")]
    [IsoXmlTag("InitlCnt")]
    public IsoNumber? InitialCount { get; init; }

    /// <summary>
    /// Media Category.
    /// </summary>
    [DisplayName("Media Category")]
    [IsoXmlTag("MdiaCtgy")]
    public ATMMediaType3Code? MediaCategory { get; init; }

    /// <summary>
    /// Unit Value.
    /// </summary>
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public ImpliedCurrencyAndAmount? UnitValue { get; init; }
}
