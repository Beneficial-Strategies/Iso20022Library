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
[IsoId("_t5V90lkyEeGeoaLUQk__nA_1997796326")]
[DisplayName("Product")]
public partial record Product2
{
    #nullable enable
    
    /// <summary>
    /// Product code of the item purchased.
    /// </summary>
    [IsoId("_t5V901kyEeGeoaLUQk__nA_1872858483")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text ProductCode { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_t5V91FkyEeGeoaLUQk__nA_-1369385922")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Product quantity.
    /// </summary>
    [IsoId("_t5fu0FkyEeGeoaLUQk__nA_-1611123080")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    
    /// <summary>
    /// Price per unit of product.
    /// </summary>
    [IsoId("_t5fu0VkyEeGeoaLUQk__nA_-850357927")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    
    /// <summary>
    /// Monetary value of purchased product.
    /// </summary>
    [IsoId("_t5fu0lkyEeGeoaLUQk__nA_-861456704")]
    [DisplayName("Product Amount")]
    [IsoXmlTag("PdctAmt")]
    public ImpliedCurrencyAndAmount? ProductAmount { get; init; } 
    
    /// <summary>
    /// Information on tax paid on the product.
    /// </summary>
    [IsoId("_t5fu01kyEeGeoaLUQk__nA_-391380294")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; } 
    
    /// <summary>
    /// Additional information related to the product.
    /// </summary>
    [IsoId("_t5o4wFkyEeGeoaLUQk__nA_442293533")]
    [DisplayName("Additional Product Information")]
    [IsoXmlTag("AddtlPdctInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalProductInformation { get; init; } 
    
    
    #nullable disable
    
}
