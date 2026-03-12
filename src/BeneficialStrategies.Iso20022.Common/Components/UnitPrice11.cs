// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_QfLNU9p-Ed-ak6NoX_4Aeg_1382237696")]
[DisplayName("Unit Price")]
public partial record UnitPrice11
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfLNVNp-Ed-ak6NoX_4Aeg_1382237940")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice10Code Type { get; init; } 
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfLNVdp-Ed-ak6NoX_4Aeg_-1892239581")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QfLNVtp-Ed-ak6NoX_4Aeg_1382237957")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QfLNV9p-Ed-ak6NoX_4Aeg_1382237974")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    
    #nullable disable
    
}
