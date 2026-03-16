// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Counterparty Pair Statistics7.
/// </summary>
[IsoId("_BUWnQZBIEe6Ojt1b3tfu9Q")]
[DisplayName("Reconciliation Counterparty Pair Statistics7")]
public record ReconciliationCounterpartyPairStatistics7
{
    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData91 CounterpartyIdentification { get; init; }

    /// <summary>
    /// Reconciliation Report.
    /// </summary>
    [DisplayName("Reconciliation Report")]
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport15> ReconciliationReport { get; init; } = [];

    /// <summary>
    /// Total Number Of Transactions.
    /// </summary>
    [DisplayName("Total Number Of Transactions")]
    [IsoXmlTag("TtlNbOfTxs")]
    public required IsoNumber TotalNumberOfTransactions { get; init; }
}
