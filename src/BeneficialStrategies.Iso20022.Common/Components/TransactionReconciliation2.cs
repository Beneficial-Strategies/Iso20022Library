// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation transaction between an acceptor and an acquirer.
/// </summary>
[IsoId("_SZI_ISqOEeKu3rbsflh_TQ")]
[DisplayName("Transaction Reconciliation")]
public record TransactionReconciliation2
{
    /// <summary>
    /// Indicates if the transaction requires a closure of the reconciliation period.
    /// </summary>
    [IsoId("_S7DZYSqOEeKu3rbsflh_TQ")]
    [DisplayName("Close Period")]
    [IsoXmlTag("ClsPrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClosePeriod { get; init; }

    /// <summary>
    /// Unique identification of a reconciliation transaction.
    /// </summary>
    [IsoId("_S7DZZSqOEeKu3rbsflh_TQ")]
    [DisplayName("Reconciliation Transaction Identification")]
    [IsoXmlTag("RcncltnTxId")]
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_S7DZaSqOEeKu3rbsflh_TQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; }

    /// <summary>
    /// Transaction totals during the reconciliation period for a certain type of transaction.
    /// </summary>
    [IsoId("_S7DZbSqOEeKu3rbsflh_TQ")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public TransactionTotals2? TransactionTotals { get; init; }

    /// <summary>
    /// Additional information related to the reconciliation transaction.
    /// </summary>
    [IsoId("_S7DZcSqOEeKu3rbsflh_TQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionData { get; init; }
}
