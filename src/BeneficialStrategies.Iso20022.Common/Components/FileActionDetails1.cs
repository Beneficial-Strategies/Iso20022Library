// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the file action to be performed.
/// </summary>
[IsoId("_7LN-oFD3Eee94_dUz-hvgw")]
[DisplayName("File Action Details")]
public partial record FileActionDetails1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the file.
    /// ISO 8583 bit 101
    /// </summary>
    [IsoId("_Ddn5sFD4Eee94_dUz-hvgw")]
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text FileName { get; init; } 
    
    /// <summary>
    /// Content of record to be added, updated, deleted or replaced.
    /// ISO 8583:93/2003 bit 72
    /// </summary>
    [IsoId("_j2qysFD6Eee94_dUz-hvgw")]
    [DisplayName("Data Record")]
    [IsoXmlTag("DataRcrd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public required IsoMax100KBinary DataRecord { get; init; } 
    
    /// <summary>
    /// Date when the file action should be performed.
    /// ISO 8583 bit 73.
    /// </summary>
    [IsoId("_shNg8FD6Eee94_dUz-hvgw")]
    [DisplayName("Action Date")]
    [IsoXmlTag("ActnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActionDate { get; init; } 
    
    /// <summary>
    /// Indicates that the originator of the message is authorised to update the file.
    /// ISO 8583:87 bit 92
    /// </summary>
    [IsoId("_U60dcFEFEee94_dUz-hvgw")]
    [DisplayName("File Security Code")]
    [IsoXmlTag("FileSctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FileSecurityCode { get; init; } 
    
    
    #nullable disable
    
}
