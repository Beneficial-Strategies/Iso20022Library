// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax exempt election details.
/// </summary>
[IsoId("_2m0Rsb5YEeexmbB7KsjCwA")]
[DisplayName("Tax Exempt Quantity SD")]
public partial record TaxExemptQuantitySD2
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_24OKwb5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Tax control identification.
    /// </summary>
    [IsoId("_24OKw75YEeexmbB7KsjCwA")]
    [DisplayName("Control Identification")]
    [IsoXmlTag("CtrlId")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text ControlIdentification { get; init; } 
    
    /// <summary>
    /// Elected quantity.
    /// </summary>
    [IsoId("_24OKy75YEeexmbB7KsjCwA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
