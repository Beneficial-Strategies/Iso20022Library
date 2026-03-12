// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of quantities.
/// </summary>
[IsoId("_mmgB2UD5EeW1yage4PQ__A")]
[DisplayName("From To Quantity Range")]
public partial record FromToQuantityRange2
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of quantity values.
    /// </summary>
    [IsoId("_mxuaYUD5EeW1yage4PQ__A")]
    [DisplayName("From Quantity")]
    [IsoXmlTag("FrQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber FromQuantity { get; init; } 
    
    /// <summary>
    /// Upper boundary of a range of quantity values.
    /// </summary>
    [IsoId("_mxuaY0D5EeW1yage4PQ__A")]
    [DisplayName("To Quantity")]
    [IsoXmlTag("ToQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber ToQuantity { get; init; } 
    
    
    #nullable disable
    
}
