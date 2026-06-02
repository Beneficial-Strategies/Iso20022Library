// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional fee reconciliation data.
/// </summary>
[IsoId("__Vo3gWP5EfCX7uJiAWHfoQ")]
[DisplayName("Additional Fee Reconciliation4")]
public record AdditionalFeeReconciliation4
{
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("__YCEMWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Impact")]
    [IsoXmlTag("Impct")]
    public required ReconciliationImpact1Code Impact { get; init; }

    /// <summary>
    /// Contains the list of additional fee types.
    /// </summary>
    [IsoId("__YCEM2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583FeeTypeCode Type { get; init; }

    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// </summary>
    [IsoId("__YCEN2P5EfCX7uJiAWHfoQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("__YCEOWP5EfCX7uJiAWHfoQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public required IsoNumber Count { get; init; }
}
