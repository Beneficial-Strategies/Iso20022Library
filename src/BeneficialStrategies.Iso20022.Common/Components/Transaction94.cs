// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation transaction
/// </summary>
[IsoId("_kmRxME96EeePXdaAO32Uew")]
[DisplayName("Transaction")]
public record Transaction94
{
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_JkyXAfGIEeiGNursv3uE_g")]
    [DisplayName("Reconciliation Function")]
    [IsoXmlTag("RcncltnFctn")]
    public required ReconciliationFunction1Code ReconciliationFunction { get; init; }

    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_EYKmwE-BEeePXdaAO32Uew")]
    [DisplayName("Reconciliation Type")]
    [IsoXmlTag("RcncltnTp")]
    public required CardServiceType4Code ReconciliationType { get; init; }

    /// <summary>
    /// Other type of reconciliation.
    /// </summary>
    [IsoId("_cFV70E-DEeePXdaAO32Uew")]
    [DisplayName("Other Reconciliation Type")]
    [IsoXmlTag("OthrRcncltnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherReconciliationType { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_E5zEAFAMEeedyPuM0kK2EQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification12? TransactionIdentification { get; init; }

    /// <summary>
    /// Requested currency by the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_--3oMcybEeiqqJhU2tqK8A")]
    [DisplayName("Requested Currency")]
    [IsoXmlTag("ReqdCcy")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? RequestedCurrency { get; init; }

    /// <summary>
    /// Totals of the reconciliation.
    /// </summary>
    [IsoId("_BWEP0FASEeedyPuM0kK2EQ")]
    [DisplayName("Reconciliation Totals")]
    [IsoXmlTag("RcncltnTtls")]
    public TransactionTotals11? ReconciliationTotals { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_NVFkYvF-EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_pq5o0RqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
