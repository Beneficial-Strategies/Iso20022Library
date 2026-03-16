// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chunk of a software package.
/// </summary>
[IsoId("_i4mQ8VFDEeyApZmLzm74zA")]
[DisplayName("Package Type")]
public record PackageType3
{
    /// <summary>
    /// Identification of the software packages of which the chunk belongs.
    /// </summary>
    [IsoId("_i-5GMVFDEeyApZmLzm74zA")]
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    public GenericIdentification176? PackageIdentification { get; init; }

    /// <summary>
    /// Full length of software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_i-5GM1FDEeyApZmLzm74zA")]
    [DisplayName("Package Length")]
    [IsoXmlTag("PackgLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? PackageLength { get; init; }

    /// <summary>
    /// Place of the first following PackageBlock, beginning with 0, in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_i-5GNVFDEeyApZmLzm74zA")]
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetStart { get; init; }

    /// <summary>
    /// Following place of the last following PackageBlock in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_i-5GN1FDEeyApZmLzm74zA")]
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetEnd { get; init; }

    /// <summary>
    /// Consecutive slices of the full software package identified through PackageIdentification starting with first slice at the place identified with OffsetStart and ending with the last slice at the previous place identified with OffsetEnd.
    /// </summary>
    [IsoId("_i-5GOVFDEeyApZmLzm74zA")]
    [DisplayName("Package Block")]
    [IsoXmlTag("PackgBlck")]
    public ExternallyDefinedData3? PackageBlock { get; init; }
}
