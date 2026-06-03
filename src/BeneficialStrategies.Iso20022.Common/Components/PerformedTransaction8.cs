// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of performed transactions.
/// </summary>
[IsoId("_QTM3AbZbEfCUZfsQO4rYeA")]
[DisplayName("Performed Transaction8")]
public record PerformedTransaction8
{
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    [IsoId("_QUHdBbZbEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    [IsoId("_QUHdC7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_QUHdEbZbEfCUZfsQO4rYeA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    [IsoId("_QUHdF7ZbEfCUZfsQO4rYeA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_QUHdHbZbEfCUZfsQO4rYeA")]
    [DisplayName("Payment Result")]
    [IsoXmlTag("PmtRslt")]
    public RetailerPaymentResult8? PaymentResult { get; init; }

    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    [IsoId("_QUHdI7ZbEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public ValueList<LoyaltyResult3> LoyaltyResult { get; init; } = [];

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    [IsoId("_QUHdKbZbEfCUZfsQO4rYeA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }
}
