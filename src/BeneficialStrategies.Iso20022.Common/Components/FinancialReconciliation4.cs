// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains financial reconciliation data.
/// </summary>
[IsoId("_eU-S8WP5EfCX7uJiAWHfoQ")]
[DisplayName("Financial Reconciliation4")]
public record FinancialReconciliation4
{
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("_eXZ74WP5EfCX7uJiAWHfoQ")]
    [DisplayName("Impact")]
    [IsoXmlTag("Impct")]
    public required ReconciliationImpact1Code Impact { get; init; }

    /// <summary>
    /// Contains the reconciliation category. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_eXZ742P5EfCX7uJiAWHfoQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReconciliationCategory2Code Type { get; init; }

    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// </summary>
    [IsoId("_eXZ752P5EfCX7uJiAWHfoQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_eXZ76WP5EfCX7uJiAWHfoQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    public required IsoNumber Count { get; init; }
}
