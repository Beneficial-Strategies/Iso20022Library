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
[IsoId("_1a-Q5jL3EeKU9IrkkToqcw_-1857619080")]
[DisplayName("Tax Exempt Quantity SD")]
public partial record TaxExemptQuantitySD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1ba80DL3EeKU9IrkkToqcw_583495269")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Tax control ID.
    /// </summary>
    [IsoId("_1ba80TL3EeKU9IrkkToqcw_-1821568371")]
    [DisplayName("Control Identification")]
    [IsoXmlTag("CtrlId")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text ControlIdentification { get; init; } 
    
    /// <summary>
    /// Elected quantity.
    /// </summary>
    [IsoId("_1bkGwDL3EeKU9IrkkToqcw_70344717")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
