// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a country by its code and its name.
/// </summary>
[IsoId("_LwvhYBIgEeamBoux7a_UUg")]
[DisplayName("Country Code And Name")]
public record CountryCodeAndName3
{
    /// <summary>
    /// Country is specified by its code.
    /// </summary>
    [IsoId("_LwvhYhIgEeamBoux7a_UUg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CountryCode Code { get; init; }

    /// <summary>
    /// Country is specified by its name.
    /// </summary>
    [IsoId("_LwvhYRIgEeamBoux7a_UUg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; }
}
