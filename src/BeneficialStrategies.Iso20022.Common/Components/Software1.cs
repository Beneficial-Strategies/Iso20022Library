// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Software1.
/// </summary>
[IsoId("_VYvPQG6hEe6DxcrvCrq6hQ")]
[DisplayName("Software1")]
public record Software1
{
    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Sub Type.
    /// </summary>
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SoftwareType1Code? Type { get; init; }

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoMax256Text? Version { get; init; }
}
