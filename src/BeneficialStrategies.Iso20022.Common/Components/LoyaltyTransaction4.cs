// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the Loyalty Transaction.
/// </summary>
[IsoId("_kqiHgU30Eey_VecAUE-C9Q")]
[DisplayName("Loyalty Transaction")]
public record LoyaltyTransaction4
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_F2hvQU7aEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_kxN-UU30Eey_VecAUE-C9Q")]
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; }

    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_kxN-U030Eey_VecAUE-C9Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_kxN-VU30Eey_VecAUE-C9Q")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_kxN-V030Eey_VecAUE-C9Q")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction120? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_kxN-WU30Eey_VecAUE-C9Q")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public Product6? SaleItem { get; init; }
}
