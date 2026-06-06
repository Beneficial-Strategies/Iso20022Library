// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Software information.
/// </summary>
[IsoId("_kj-g8Hn0EfCmC4yYaU27Kg")]
[DisplayName("Software2")]
public record Software2
{
    /// <summary>
    /// Software type code. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_kmgQgXn0EfCmC4yYaU27Kg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SoftwareType2Code? Type { get; init; }

    /// <summary>
    /// Software Subtype.
    /// </summary>
    [IsoId("_kmgQhXn0EfCmC4yYaU27Kg")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Software version.
    /// </summary>
    [IsoId("_kmgQh3n0EfCmC4yYaU27Kg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }
}
