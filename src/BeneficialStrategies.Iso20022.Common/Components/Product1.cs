// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product purchased to be paid.
/// </summary>
[IsoId("_S5n9VQEcEeCQm6a_G2yO_w_-1742232197")]
[DisplayName("Product")]
public partial record Product1
{
    #nullable enable
    
    /// <summary>
    /// Product code of the item purchased.
    /// </summary>
    [IsoId("_S5n9VgEcEeCQm6a_G2yO_w_1162953379")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_S5n9VwEcEeCQm6a_G2yO_w_-1799162446")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Product quantity.
    /// </summary>
    [IsoId("_S5n9WAEcEeCQm6a_G2yO_w_1135821836")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    
    /// <summary>
    /// Price per unit of product.
    /// </summary>
    [IsoId("_S5n9WQEcEeCQm6a_G2yO_w_-187172115")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    
    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    [IsoId("_S5n9WgEcEeCQm6a_G2yO_w_1805880585")]
    [DisplayName("Product Amount")]
    [IsoXmlTag("PdctAmt")]
    public required ImpliedCurrencyAndAmount ProductAmount { get; init; } 
    
    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    [IsoId("_S5n9WwEcEeCQm6a_G2yO_w_2065867559")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; } 
    
    /// <summary>
    /// Additional information related to the product.
    /// </summary>
    [IsoId("_S5n9XAEcEeCQm6a_G2yO_w_-236047037")]
    [DisplayName("Additional Product Information")]
    [IsoXmlTag("AddtlPdctInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalProductInformation { get; init; } 
    
    
    #nullable disable
    
}
