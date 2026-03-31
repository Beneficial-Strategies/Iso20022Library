// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a country by its code or its name.
/// </summary>
[IsoId("_SuJtKQEcEeCQm6a_G2yO_w_1027665844")]
[DisplayName("Country Code And Name")]
public record CountryCodeAndName1
{
    /// <summary>
    /// Country is specified by its code.
    /// </summary>
    [IsoId("_SuJtKgEcEeCQm6a_G2yO_w_-340916630")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public CountryCode? Code { get; init; }

    /// <summary>
    /// Country is specified by its name.
    /// </summary>
    [IsoId("_SuJtKwEcEeCQm6a_G2yO_w_-1022463879")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }
}
