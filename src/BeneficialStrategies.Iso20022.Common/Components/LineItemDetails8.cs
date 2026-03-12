// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the current situation of a line item as a result of the submission of a commercial dataset.
/// </summary>
[IsoId("_SscWJdp-Ed-ak6NoX_4Aeg_245671612")]
[DisplayName("Line Item Details")]
public partial record LineItemDetails8
{
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_SscWJtp-Ed-ak6NoX_4Aeg_245671614")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; } 
    
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_SscWJ9p-Ed-ak6NoX_4Aeg_245671666")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; } 
    
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_SscWKNp-Ed-ak6NoX_4Aeg_246592345")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; } 
    
    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_SscWKdp-Ed-ak6NoX_4Aeg_246592654")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; } 
    
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_SscWKtp-Ed-ak6NoX_4Aeg_246592623")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    
    /// <summary>
    /// Quantity ordered for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_SslgENp-Ed-ak6NoX_4Aeg_246592114")]
    [DisplayName("Ordered Quantity")]
    [IsoXmlTag("OrdrdQty")]
    public required Quantity4 OrderedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity accepted by data set submission.
    /// </summary>
    [IsoId("_SslgEdp-Ed-ak6NoX_4Aeg_246592131")]
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public required Quantity4 AcceptedQuantity { get; init; } 
    
    /// <summary>
    /// Difference between the ordered quantity and the accepted one.
    /// </summary>
    [IsoId("_SslgEtp-Ed-ak6NoX_4Aeg_246592223")]
    [DisplayName("Outstanding Quantity")]
    [IsoXmlTag("OutsdngQty")]
    public required Quantity4 OutstandingQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of a product for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_SslgE9p-Ed-ak6NoX_4Aeg_246592192")]
    [DisplayName("Pending Quantity")]
    [IsoXmlTag("PdgQty")]
    public required Quantity4 PendingQuantity { get; init; } 
    
    /// <summary>
    /// Variance allowed on the quantity of goods.
    /// </summary>
    [IsoId("_SslgFNp-Ed-ak6NoX_4Aeg_-1627859997")]
    [DisplayName("Quantity Tolerance")]
    [IsoXmlTag("QtyTlrnce")]
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    
    /// <summary>
    /// Price multiplied by the ordered quantity for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_SslgFdp-Ed-ak6NoX_4Aeg_245671944")]
    [DisplayName("Ordered Amount")]
    [IsoXmlTag("OrdrdAmt")]
    public required CurrencyAndAmount OrderedAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the accepted quantity for a line.
    /// </summary>
    [IsoId("_SslgFtp-Ed-ak6NoX_4Aeg_245671975")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public required CurrencyAndAmount AcceptedAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the outstanding quantity for a line.
    /// </summary>
    [IsoId("_SslgF9p-Ed-ak6NoX_4Aeg_245672067")]
    [DisplayName("Outstanding Amount")]
    [IsoXmlTag("OutsdngAmt")]
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the pending quantity for a line.
    /// </summary>
    [IsoId("_SslgGNp-Ed-ak6NoX_4Aeg_245672036")]
    [DisplayName("Pending Amount")]
    [IsoXmlTag("PdgAmt")]
    public required CurrencyAndAmount PendingAmount { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_SsvRENp-Ed-ak6NoX_4Aeg_246592315")]
    [DisplayName("Price Tolerance")]
    [IsoXmlTag("PricTlrnce")]
    public PercentageTolerance1? PriceTolerance { get; init; } 
    
    
    #nullable disable
    
}
