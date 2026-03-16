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
[IsoId("_l6FtIU0_Eeybj420QgWBkA")]
[DisplayName("Performed Transaction")]
public record PerformedTransaction4
{
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    [IsoId("_mAsEYU0_Eeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    [IsoId("_mAsEY00_Eeybj420QgWBkA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_mAsEZU0_Eeybj420QgWBkA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    [IsoId("_mAsEZ00_Eeybj420QgWBkA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_mAsEaU0_Eeybj420QgWBkA")]
    [DisplayName("Payment Result")]
    [IsoXmlTag("PmtRslt")]
    public RetailerPaymentResult4? PaymentResult { get; init; }

    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    [IsoId("_mAsEa00_Eeybj420QgWBkA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public LoyaltyResult3? LoyaltyResult { get; init; }

    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    [IsoId("_mAsEbU0_Eeybj420QgWBkA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }
}
