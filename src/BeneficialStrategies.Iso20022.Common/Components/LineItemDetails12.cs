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
[IsoId("_9oAg0wy6EeS3puOfnJm56A")]
[DisplayName("Line Item Details")]
public partial record LineItemDetails12
{
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to a line item.
    /// </summary>
    [IsoId("_994DEQy6EeS3puOfnJm56A")]
    [DisplayName("Line Item Identification")]
    [IsoXmlTag("LineItmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text LineItemIdentification { get; init; } 
    
    /// <summary>
    /// Name of the product detailed in the corresponding line item.
    /// </summary>
    [IsoId("_994DEwy6EeS3puOfnJm56A")]
    [DisplayName("Product Name")]
    [IsoXmlTag("PdctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProductName { get; init; } 
    
    /// <summary>
    /// Identifies the product of the corresponding line item.
    /// </summary>
    [IsoId("_994DFQy6EeS3puOfnJm56A")]
    [DisplayName("Product Identifier")]
    [IsoXmlTag("PdctIdr")]
    public ProductIdentifier2Choice_? ProductIdentifier { get; init; } 
    
    /// <summary>
    /// Identifies the characteristic of a product.
    /// </summary>
    [IsoId("_994DFwy6EeS3puOfnJm56A")]
    [DisplayName("Product Characteristics")]
    [IsoXmlTag("PdctChrtcs")]
    public ProductCharacteristics1Choice_? ProductCharacteristics { get; init; } 
    
    /// <summary>
    /// Identifies the category of product.
    /// </summary>
    [IsoId("_994DGQy6EeS3puOfnJm56A")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public ProductCategory1Choice_? ProductCategory { get; init; } 
    
    /// <summary>
    /// Quantity ordered for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_994DGwy6EeS3puOfnJm56A")]
    [DisplayName("Ordered Quantity")]
    [IsoXmlTag("OrdrdQty")]
    public required Quantity9 OrderedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity accepted by data set submission.
    /// </summary>
    [IsoId("_994DHQy6EeS3puOfnJm56A")]
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public required Quantity9 AcceptedQuantity { get; init; } 
    
    /// <summary>
    /// Difference between the ordered quantity and the accepted one.
    /// </summary>
    [IsoId("_994DHwy6EeS3puOfnJm56A")]
    [DisplayName("Outstanding Quantity")]
    [IsoXmlTag("OutsdngQty")]
    public required Quantity9 OutstandingQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of a product for which a mismatched data set has been submitted and has not yet been accepted or rejected.
    /// </summary>
    [IsoId("_994DIQy6EeS3puOfnJm56A")]
    [DisplayName("Pending Quantity")]
    [IsoXmlTag("PdgQty")]
    public required Quantity9 PendingQuantity { get; init; } 
    
    /// <summary>
    /// Variance allowed on the quantity of goods.
    /// </summary>
    [IsoId("_994DIwy6EeS3puOfnJm56A")]
    [DisplayName("Quantity Tolerance")]
    [IsoXmlTag("QtyTlrnce")]
    public PercentageTolerance1? QuantityTolerance { get; init; } 
    
    /// <summary>
    /// Price multiplied by the ordered quantity for a line as indicated in the baseline.
    /// </summary>
    [IsoId("_994DJQy6EeS3puOfnJm56A")]
    [DisplayName("Ordered Amount")]
    [IsoXmlTag("OrdrdAmt")]
    public required CurrencyAndAmount OrderedAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the accepted quantity for a line.
    /// </summary>
    [IsoId("_994DJwy6EeS3puOfnJm56A")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public required CurrencyAndAmount AcceptedAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the outstanding quantity for a line.
    /// </summary>
    [IsoId("_994DKQy6EeS3puOfnJm56A")]
    [DisplayName("Outstanding Amount")]
    [IsoXmlTag("OutsdngAmt")]
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    
    /// <summary>
    /// Price multiplied by the pending quantity for a line.
    /// </summary>
    [IsoId("_994DKwy6EeS3puOfnJm56A")]
    [DisplayName("Pending Amount")]
    [IsoXmlTag("PdgAmt")]
    public required CurrencyAndAmount PendingAmount { get; init; } 
    
    /// <summary>
    /// Variance on price for the goods.
    /// </summary>
    [IsoId("_994DLQy6EeS3puOfnJm56A")]
    [DisplayName("Price Tolerance")]
    [IsoXmlTag("PricTlrnce")]
    public PercentageTolerance1? PriceTolerance { get; init; } 
    
    
    #nullable disable
    
}
