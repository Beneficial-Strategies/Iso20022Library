// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters for an Isabel payment file.
/// </summary>
[IsoId("_ji0LAMmIEeWAGphE2LvqeA")]
[DisplayName("Isabel File")]
public partial record IsabelFile1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the file.	.
    /// </summary>
    [IsoId("_rZhBgMmIEeWAGphE2LvqeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max14AlphaNumericText)]
    [StringLength(maximumLength: 14 ,MinimumLength = 1)]
    public required IsoMax14AlphaNumericText Identification { get; init; } 
    
    /// <summary>
    /// Unique identification of the originator of the file.
    /// </summary>
    [IsoId("_2XvCkcmIEeWAGphE2LvqeA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.Max14AlphaNumericText)]
    [StringLength(maximumLength: 14 ,MinimumLength = 1)]
    public IsoMax14AlphaNumericText? Originator { get; init; } 
    
    /// <summary>
    /// Size of the file.
    /// </summary>
    [IsoId("_AMHtwMmJEeWAGphE2LvqeA")]
    [DisplayName("Size")]
    [IsoXmlTag("Sz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Size { get; init; } 
    
    /// <summary>
    /// Format of the file.
    /// </summary>
    [IsoId("_DXfdkMmJEeWAGphE2LvqeA")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text Format { get; init; } 
    
    /// <summary>
    /// Version of the format of the file.
    /// </summary>
    [IsoId("_IjaI0MmJEeWAGphE2LvqeA")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? FormatVersion { get; init; } 
    
    /// <summary>
    /// Length of the individual records in the file.
    /// </summary>
    [IsoId("_S3XE4MmJEeWAGphE2LvqeA")]
    [DisplayName("Record Length")]
    [IsoXmlTag("RcrdLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? RecordLength { get; init; } 
    
    
    #nullable disable
    
}
