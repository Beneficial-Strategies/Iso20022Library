// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the expected collateral type and direction.
/// </summary>
[IsoId("__DOQZYLZEeWrrO9HojbPQA")]
[DisplayName("Expected Collateral Movement")]
public partial record ExpectedCollateralMovement2
{
    #nullable enable
    
    /// <summary>
    /// Type of collateral that will be delivered and date by which the collateral movement is expected.
    /// </summary>
    [IsoId("__cEOMYLZEeWrrO9HojbPQA")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public CollateralMovement9? Delivery { get; init; } 
    
    /// <summary>
    /// Type of collateral that will be returned and date by which the collateral movement is expected.
    /// </summary>
    [IsoId("__cEOM4LZEeWrrO9HojbPQA")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public CollateralMovement9? Return { get; init; } 
    
    
    #nullable disable
    
}
