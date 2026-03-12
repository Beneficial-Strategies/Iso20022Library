// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities quantity details.
/// </summary>
[IsoId("_1Tg-BDL3EeKU9IrkkToqcw_100913182")]
[DisplayName("Securities Option SD")]
public partial record SecuritiesOptionSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Tg-BTL3EeKU9IrkkToqcw_1533207276")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Maximum oversubscription amount for the option.
    /// </summary>
    [IsoId("_1TqvADL3EeKU9IrkkToqcw_-249092493")]
    [DisplayName("Maximum Oversubscription Quantity")]
    [IsoXmlTag("MaxOvrsbcptQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? MaximumOversubscriptionQuantity { get; init; } 
    
    
    #nullable disable
    
}
