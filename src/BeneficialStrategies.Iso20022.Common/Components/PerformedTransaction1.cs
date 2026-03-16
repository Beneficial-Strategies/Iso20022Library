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
[IsoId("_XRIDwNxWEeioifFt1dhnJA")]
[DisplayName("Performed Transaction")]
public record PerformedTransaction1
{
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    [IsoId("_dCYQsNxWEeioifFt1dhnJA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    [IsoId("_gRXDQNxYEeioifFt1dhnJA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_jis4MNxYEeioifFt1dhnJA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    [IsoId("_o_NkMNxYEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_sikWMNxYEeioifFt1dhnJA")]
    [DisplayName("Payment Result")]
    [IsoXmlTag("PmtRslt")]
    public RetailerPaymentResult1? PaymentResult { get; init; }

    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    [IsoId("_v6QDsNxYEeioifFt1dhnJA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public ValueList<LoyaltyResult1> LoyaltyResult { get; init; } = [];

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    [IsoId("_y5YHQNxYEeioifFt1dhnJA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }
}
