// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Statistics Per Counterparty4.
/// </summary>
[IsoId("_BTiH5ZBIEe6Ojt1b3tfu9Q")]
[DisplayName("Reconciliation Statistics Per Counterparty4")]
public record ReconciliationStatisticsPerCounterparty4
{
    /// <summary>
    /// Reconciliation Categories.
    /// </summary>
    [DisplayName("Reconciliation Categories")]
    [IsoXmlTag("RcncltnCtgrs")]
    public required ReportingRequirement3Choice_ ReconciliationCategories { get; init; }

    /// <summary>
    /// Reference Date.
    /// </summary>
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    public required IsoISODate ReferenceDate { get; init; }

    /// <summary>
    /// Total Number Of Transactions.
    /// </summary>
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    public IsoNumber? TotalNumberOfTransactions { get; init; }

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<ReconciliationCounterpartyPairStatistics7> TransactionDetails { get; init; } =
        [];
}
