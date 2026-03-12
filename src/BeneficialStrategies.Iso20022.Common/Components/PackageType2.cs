// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chunk of a software package.
/// </summary>
[IsoId("_DHZnYS9EEeu125Ip9zFcsQ")]
[DisplayName("Package Type")]
public partial record PackageType2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the software packages of which the chunk belongs.
    /// </summary>
    [IsoId("_DU2NgS9EEeu125Ip9zFcsQ")]
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    public GenericIdentification176? PackageIdentification { get; init; } 
    
    /// <summary>
    /// Full length of software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_DU2Ngy9EEeu125Ip9zFcsQ")]
    [DisplayName("Package Length")]
    [IsoXmlTag("PackgLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? PackageLength { get; init; } 
    
    /// <summary>
    /// Place of the first following PackageBlock, beginning with 0, in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_DU2NhS9EEeu125Ip9zFcsQ")]
    [DisplayName("Offset Start")]
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetStart { get; init; } 
    
    /// <summary>
    /// Following place of the last following PackageBlock in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_DU2Nhy9EEeu125Ip9zFcsQ")]
    [DisplayName("Offset End")]
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    
    /// <summary>
    /// Consecutive slices of the full software package identified through PackageIdentification starting with first slice at the place identified with OffsetStart and ending with the last slice at the previous place identified with OffsetEnd.
    /// </summary>
    [IsoId("_DU2NiS9EEeu125Ip9zFcsQ")]
    [DisplayName("Package Block")]
    [IsoXmlTag("PackgBlck")]
    public ExternallyDefinedData2? PackageBlock { get; init; } 
    
    
    #nullable disable
    
}
