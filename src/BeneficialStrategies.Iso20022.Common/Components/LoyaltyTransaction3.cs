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
[IsoId("_pxwEMS83Eeu125Ip9zFcsQ")]
[DisplayName("Loyalty Transaction")]
public record LoyaltyTransaction3
{
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_p-jxIS83Eeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; }

    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_p-jxIy83Eeu125Ip9zFcsQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_p-jxJS83Eeu125Ip9zFcsQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_p-jxJy83Eeu125Ip9zFcsQ")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction110? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_p-jxKS83Eeu125Ip9zFcsQ")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public Product6? SaleItem { get; init; }
}
