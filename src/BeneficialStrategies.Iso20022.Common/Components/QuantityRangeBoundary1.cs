// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit for a quantity range.
/// </summary>
[IsoId("_jtRfFe5NEeCisYr99QEiWA_-1438940377")]
[DisplayName("Quantity Range Boundary")]
public partial record QuantityRangeBoundary1
{
    #nullable enable
    
    /// <summary>
    /// Quantity value of the range limit.
    /// </summary>
    [IsoId("_jtapAO5NEeCisYr99QEiWA_-330775982")]
    [DisplayName("Boundary")]
    [IsoXmlTag("Bdry")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Boundary { get; init; } 
    
    /// <summary>
    /// Indicates whether the boundary quantity is included in the range of quantity values.
    /// </summary>
    [IsoId("_jtapAe5NEeCisYr99QEiWA_279625946")]
    [DisplayName("Included")]
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Included { get; init; } 
    
    
    #nullable disable
    
}
