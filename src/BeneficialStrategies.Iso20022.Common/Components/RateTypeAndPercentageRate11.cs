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
[IsoId("_n05_4dBcEee0mNiKMkpGNQ")]
[DisplayName("Rate Type And Percentage Rate")]
public partial record RateTypeAndPercentageRate11
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_oGkXodBcEee0mNiKMkpGNQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required DeemedRateType2Choice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    [IsoId("_oGkXo9BcEee0mNiKMkpGNQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    
    #nullable disable
    
}
