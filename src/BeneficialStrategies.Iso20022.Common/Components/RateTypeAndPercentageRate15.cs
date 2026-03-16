// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate Type And Percentage Rate15.
/// </summary>
[IsoId("_kV6w25t3Ee-wQIOX0djF2w")]
[DisplayName("Rate Type And Percentage Rate15")]
public partial record RateTypeAndPercentageRate15
{
    #nullable enable

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public required IsoPercentage14Rate Rate { get; init; } 

    /// <summary>
    /// Rate Type.
    /// </summary>
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType46Choice_ RateType { get; init; } 

    
    #nullable disable
    
}
