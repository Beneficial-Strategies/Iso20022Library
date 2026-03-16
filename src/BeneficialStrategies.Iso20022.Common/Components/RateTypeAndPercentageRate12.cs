// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate Type And Percentage Rate12.
/// </summary>
[IsoId("_2o18kYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Rate Type And Percentage Rate12")]
public record RateTypeAndPercentageRate12
{
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
    public required RateType42Choice_ RateType { get; init; }
}
