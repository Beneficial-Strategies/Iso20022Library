// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty Transaction6.
/// </summary>
[IsoId("_kKUwgZLNEe6-zvj9Dw-ctg")]
[DisplayName("Loyalty Transaction6")]
public partial record LoyaltyTransaction6
{
    #nullable enable

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 

    /// <summary>
    /// Loyalty Transaction Type.
    /// </summary>
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 

    /// <summary>
    /// Original POI Transaction.
    /// </summary>
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction136? OriginalPOITransaction { get; init; } 

    /// <summary>
    /// Sale Item.
    /// </summary>
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public ValueList<Product6> SaleItem { get; init; } = [];

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 

    
    #nullable disable
    
}
