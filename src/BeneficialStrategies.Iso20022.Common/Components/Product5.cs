// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product to purchase.
/// </summary>
[IsoId("_lPknoZVaEeWuuIjj4l7kpg")]
[DisplayName("Product")]
public partial record Product5
{
    #nullable enable
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_lbSIY5VaEeWuuIjj4l7kpg")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; } 
    
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_lbSIZZVaEeWuuIjj4l7kpg")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    
    /// <summary>
    /// Amount limit for the product.
    /// </summary>
    [IsoId("_lbSIb5VaEeWuuIjj4l7kpg")]
    [DisplayName("Amount Limit")]
    [IsoXmlTag("AmtLmt")]
    public ImpliedCurrencyAndAmount? AmountLimit { get; init; } 
    
    /// <summary>
    /// Quantity limit for the product.
    /// </summary>
    [IsoId("_lbSIaZVaEeWuuIjj4l7kpg")]
    [DisplayName("Quantity Limit")]
    [IsoXmlTag("QtyLmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? QuantityLimit { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_lbSIZ5VaEeWuuIjj4l7kpg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    
    
    #nullable disable
    
}
