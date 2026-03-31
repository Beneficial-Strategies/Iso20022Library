// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Reconciliation Response message.
/// </summary>
[IsoId("_wlhKENxfEeioifFt1dhnJA")]
[DisplayName("Reconciliation Response Data")]
public record ReconciliationResponseData1
{
    /// <summary>
    /// Type of Reconciliation requested by the Sale to the POI.
    /// </summary>
    [IsoId("_2aeLQNxfEeioifFt1dhnJA")]
    [DisplayName("Reconciliation Type")]
    [IsoXmlTag("RcncltnTp")]
    public required ReconciliationType1Code ReconciliationType { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [IsoId("_505qwNxfEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Result of the Sale to POI Reconciliation processing.
    /// </summary>
    [IsoId("_9SsAQNxfEeioifFt1dhnJA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotalsSet1> TransactionTotals { get; init; } = [];
}
