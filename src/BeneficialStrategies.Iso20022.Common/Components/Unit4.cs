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
[IsoId("_72Uo4xgKEeKqWJINzXcn5g")]
[DisplayName("Unit")]
public partial record Unit4
{
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_jQnpABgLEeKqWJINzXcn5g")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_swUdoBgLEeKqWJINzXcn5g")]
    [DisplayName("Unit Details")]
    [IsoXmlTag("UnitDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Unit5> UnitDetails { get; init; } = new ValueList<Unit5>(){};
    
    
    #nullable disable
    
}
