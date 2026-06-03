// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the loyalty transaction.
/// </summary>
[IsoId("_vCp40bZZEfCUZfsQO4rYeA")]
[DisplayName("Loyalty Transaction8")]
public record LoyaltyTransaction8
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_vDsapbZZEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_vDsaq7ZZEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; }

    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_vDsasbZZEfCUZfsQO4rYeA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the payment transaction related to the loyalty.
    /// </summary>
    [IsoId("_vDsat7ZZEfCUZfsQO4rYeA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_vDsavbZZEfCUZfsQO4rYeA")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public PaymentTransaction183? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_vDsaw7ZZEfCUZfsQO4rYeA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product6> SaleItem { get; init; } = [];
}
