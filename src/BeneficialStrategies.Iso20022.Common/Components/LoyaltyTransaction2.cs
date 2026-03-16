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
[IsoId("_F20XYQ0zEeqUVL7sB4m7NA")]
[DisplayName("Loyalty Transaction")]
public record LoyaltyTransaction2
{
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_GCmwoQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; }

    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_GCmwow0zEeqUVL7sB4m7NA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_GCmwpQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_GCmwpw0zEeqUVL7sB4m7NA")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction100? OriginalPOITransaction { get; init; }

    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_GCmwqQ0zEeqUVL7sB4m7NA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product6> SaleItem { get; init; } = [];
}
