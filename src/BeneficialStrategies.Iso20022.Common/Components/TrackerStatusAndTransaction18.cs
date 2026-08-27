// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and its status to be updated in the tracker.
/// </summary>
[IsoId("_PmaSkUN8Ee-QZYT2pcGFZw")]
[DisplayName("Tracker Status And Transaction18")]
public record TrackerStatusAndTransaction18
{
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_PtkDdUN8Ee-QZYT2pcGFZw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<TrackerPaymentTransaction14> Transaction { get; init; } = [];

    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_PtkDc0N8Ee-QZYT2pcGFZw")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TrackerStatus4 TransactionStatus { get; init; }
}
