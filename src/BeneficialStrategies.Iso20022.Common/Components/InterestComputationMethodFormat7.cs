// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between a standard code or proprietary code to specify the type of interest computation method.
/// </summary>
[IsoId("_YO9D8XitEeqKjIYaFgh_2g")]
[DisplayName("Interest Computation Method Format")]
public partial record InterestComputationMethodFormat7
{
    #nullable enable
    
    /// <summary>
    /// Standard code to specify the method used to compute accruing interest of a financial instrument.
    /// </summary>
    [IsoId("_YPsq0XitEeqKjIYaFgh_2g")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required InterestComputationMethod4Code Code { get; init; } 
    
    /// <summary>
    /// The computation method can not be represented in the predefined fields.
    /// </summary>
    [IsoId("_2h3KIH_yEeqdQubSe21TTw")]
    [DisplayName("Narrative")]
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? Narrative { get; init; } 
    
    
    #nullable disable
    
}
