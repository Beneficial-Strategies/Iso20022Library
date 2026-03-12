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
[IsoId("_4VL0wZb7Eeuc6pwKtqbEVQ")]
[DisplayName("File Action Details")]
public partial record FileActionDetails2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the file.
    /// ISO 8583 bit 101
    /// </summary>
    [IsoId("_4bWuMZb7Eeuc6pwKtqbEVQ")]
    [DisplayName("File Name")]
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? FileName { get; init; } 
    
    /// <summary>
    /// File format code.
    /// </summary>
    [IsoId("_RwdhYCxOEeyg-aG5nXcnfg")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat5Code? Format { get; init; } 
    
    /// <summary>
    /// Content of record to be added, updated, deleted or replaced.
    /// ISO 8583:93/2003 bit 72
    /// </summary>
    [IsoId("_4bWuM5b7Eeuc6pwKtqbEVQ")]
    [DisplayName("Data Record")]
    [IsoXmlTag("DataRcrd")]
    public required DataRecord1Choice_ DataRecord { get; init; } 
    
    /// <summary>
    /// Date when the file action should be performed.
    /// ISO 8583 bit 73.
    /// </summary>
    [IsoId("_4bWuNZb7Eeuc6pwKtqbEVQ")]
    [DisplayName("Action Date")]
    [IsoXmlTag("ActnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActionDate { get; init; } 
    
    /// <summary>
    /// Indicates that the originator of the message is authorised to update the file.
    /// ISO 8583:87 bit 92
    /// </summary>
    [IsoId("_4bWuN5b7Eeuc6pwKtqbEVQ")]
    [DisplayName("File Security Code")]
    [IsoXmlTag("FileSctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FileSecurityCode { get; init; } 
    
    
    #nullable disable
    
}
