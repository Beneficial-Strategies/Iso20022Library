// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Allows the user to specify the algorithm parameters for the algo strategy.
/// </summary>
[IsoId("_Q8h3tNp-Ed-ak6NoX_4Aeg_111456312")]
[DisplayName("Strategy Parameters")]
public partial record StrategyParameters1
{
    #nullable enable
    
    /// <summary>
    /// Name of parameter.
    /// </summary>
    [IsoId("_Q8h3tdp-Ed-ak6NoX_4Aeg_483637209")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Type of the parameter.
    /// </summary>
    [IsoId("_Q8h3ttp-Ed-ak6NoX_4Aeg_611081607")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Defines the target strategy of the order, specifies the type of trading or algorithm strategy.
    /// </summary>
    [IsoId("_Q8rosNp-Ed-ak6NoX_4Aeg_-917891804")]
    [DisplayName("Target Strategy")]
    [IsoXmlTag("TrgtStrtgy")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? TargetStrategy { get; init; } 
    
    
    #nullable disable
    
}
