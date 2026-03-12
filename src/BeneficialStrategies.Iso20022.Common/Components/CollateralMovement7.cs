// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the agreed amount and the collateral movement direction.
/// </summary>
[IsoId("_xv755YFvEeWtPe6Crjmeug")]
[DisplayName("Collateral Movement")]
public partial record CollateralMovement7
{
    #nullable enable
    
    /// <summary>
    /// Provides the call amount that is agreed and that will result in a collateral movement.
    /// </summary>
    [IsoId("_yGZ5IYFvEeWtPe6Crjmeug")]
    [DisplayName("Agreed Amount")]
    [IsoXmlTag("AgrdAmt")]
    public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
    
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
    /// </summary>
    [IsoId("_yGZ5I4FvEeWtPe6Crjmeug")]
    [DisplayName("Movement Direction")]
    [IsoXmlTag("MvmntDrctn")]
    public CollateralMovement4Choice_? MovementDirection { get; init; } 
    
    
    #nullable disable
    
}
