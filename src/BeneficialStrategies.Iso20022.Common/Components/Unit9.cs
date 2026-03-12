// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity expressed as a number and its details.
/// </summary>
[IsoId("_6jzzka5xEeeMy7TnJ3e__g")]
[DisplayName("Unit")]
public partial record Unit9
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_6zRy8a5xEeeMy7TnJ3e__g")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_6zRy865xEeeMy7TnJ3e__g")]
    [DisplayName("Unit Details")]
    [IsoXmlTag("UnitDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Unit10> UnitDetails { get; init; } = new ValueList<Unit10>(){};
    
    
    #nullable disable
    
}
