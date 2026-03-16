// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information of the device operating system.
/// </summary>
[IsoId("_1BW5MJfPEeuqNYk2TG3bTg")]
[DisplayName("Device Operating System")]
public record DeviceOperatingSystem1
{
    /// <summary>
    /// Identification of the operating system.
    /// </summary>
    [IsoId("_EPWGUJfQEeuqNYk2TG3bTg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Type of device operating system.
    /// </summary>
    [IsoId("_F0VcQJfSEeuqNYk2TG3bTg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DeviceOperatingSystemType1Code? Type { get; init; }

    /// <summary>
    /// Other type of operating system.
    /// </summary>
    [IsoId("_SE8SQJfSEeuqNYk2TG3bTg")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Version of device operating system.
    /// </summary>
    [IsoId("_XS-dYJfSEeuqNYk2TG3bTg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Version { get; init; }

    /// <summary>
    /// Build of the device operating system.
    /// </summary>
    [IsoId("_cBT0wJfSEeuqNYk2TG3bTg")]
    [DisplayName("Build")]
    [IsoXmlTag("Bld")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Build { get; init; }
}
