// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Response Data2.
/// </summary>
[IsoId("_RDNicZ9rEe-nbM0aSPcoiQ")]
[DisplayName("Reconciliation Response Data2")]
public record ReconciliationResponseData2
{
    /// <summary>
    /// POI Reconciliation Identification.
    /// </summary>
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Reconciliation Type.
    /// </summary>
    [DisplayName("Reconciliation Type")]
    [IsoXmlTag("RcncltnTp")]
    public required ReconciliationType1Code ReconciliationType { get; init; }

    /// <summary>
    /// Transaction Totals.
    /// </summary>
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotalsSet2> TransactionTotals { get; init; } = [];
}
