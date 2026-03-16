// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate Type And Percentage Rate18.
/// </summary>
[IsoId("_l6T9K5t3Ee-wQIOX0djF2w")]
[DisplayName("Rate Type And Percentage Rate18")]
public partial record RateTypeAndPercentageRate18
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
