// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the Loyalty Transaction.
/// </summary>
[IsoId("_2XlUkNuJEeiB5uLfkg9ZJA")]
[DisplayName("Loyalty Transaction")]
public partial record LoyaltyTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_90WysNuKEeiB5uLfkg9ZJA")]
    [DisplayName("Loyalty Transaction Type")]
    [IsoXmlTag("LltyTxTp")]
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 
    
    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_BJlpINuLEeiB5uLfkg9ZJA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_EIBwMNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_IQTNINuLEeiB5uLfkg9ZJA")]
    [DisplayName("Original POI Transaction")]
    [IsoXmlTag("OrgnlPOITx")]
    public CardPaymentTransaction91? OriginalPOITransaction { get; init; } 
    
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_OynqoNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public Product6? SaleItem { get; init; } 
    
    
    #nullable disable
    
}
