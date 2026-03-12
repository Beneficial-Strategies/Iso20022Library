// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of collateral that will be delivered and the date to be reported.
/// </summary>
[IsoId("_WPYN8ILaEeWrrO9HojbPQA")]
[DisplayName("Collateral Movement")]
public partial record CollateralMovement9
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral.
    /// </summary>
    [IsoId("_k6GggILbEeWrrO9HojbPQA")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType1Code CollateralType { get; init; } 
    
    /// <summary>
    /// Date by which the collateral movement must be executed.
    /// </summary>
    [IsoId("_r2gR8ILbEeWrrO9HojbPQA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    
    #nullable disable
    
}
