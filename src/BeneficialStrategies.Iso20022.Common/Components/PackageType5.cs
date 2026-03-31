// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Package Type5.
/// </summary>
[IsoId("_Ur-K4ZEGEe6Un9Rms6YuCg")]
[DisplayName("Package Type5")]
public record PackageType5
{
    /// <summary>
    /// Offset End.
    /// </summary>
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    public IsoPositiveNumber? OffsetEnd { get; init; }

    /// <summary>
    /// Offset Start.
    /// </summary>
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    public IsoPositiveNumber? OffsetStart { get; init; }

    /// <summary>
    /// Package Block.
    /// </summary>
    [DisplayName("Package Block")]
    [IsoXmlTag("PackgBlck")]
    public ValueList<ExternallyDefinedData5> PackageBlock { get; init; } = [];

    /// <summary>
    /// Package Identification.
    /// </summary>
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    public GenericIdentification176? PackageIdentification { get; init; }

    /// <summary>
    /// Package Length.
    /// </summary>
    [DisplayName("Package Length")]
    [IsoXmlTag("PackgLngth")]
    public IsoPositiveNumber? PackageLength { get; init; }
}
