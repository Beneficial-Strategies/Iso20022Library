// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a deemed rate type and a percentage rate.
/// </summary>
[IsoId("_8eXKI5SmEeeh5JjedkaA_g")]
[DisplayName("Rate Type And Percentage Rate")]
public partial record RateTypeAndPercentageRate10
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_8eXKJZSmEeeh5JjedkaA_g")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required DeemedRateType1Choice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    [IsoId("_8eXKJJSmEeeh5JjedkaA_g")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    
    #nullable disable
    
}
