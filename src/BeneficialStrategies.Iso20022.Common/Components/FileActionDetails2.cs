// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the file action to be performed.
/// </summary>
[IsoId("_4VL0wZb7Eeuc6pwKtqbEVQ")]
[DisplayName("File Action Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FileActionDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FileActionDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FileActionDetails2( DataRecord1Choice_ reqDataRecord )
    {
        DataRecord = reqDataRecord;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the file.
    /// ISO 8583 bit 101
    /// </summary>
    [IsoId("_4bWuMZb7Eeuc6pwKtqbEVQ")]
    [DisplayName("File Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileNm")]
    #endif
    [IsoXmlTag("FileNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? FileName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileName { get; init; } 
    #else
    public System.String? FileName { get; set; } 
    #endif
    
    /// <summary>
    /// File format code.
    /// </summary>
    [IsoId("_RwdhYCxOEeyg-aG5nXcnfg")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat5Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat5Code? Format { get; init; } 
    #else
    public OutputFormat5Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Content of record to be added, updated, deleted or replaced.
    /// ISO 8583:93/2003 bit 72
    /// </summary>
    [IsoId("_4bWuM5b7Eeuc6pwKtqbEVQ")]
    [DisplayName("Data Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataRcrd")]
    #endif
    [IsoXmlTag("DataRcrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataRecord1Choice_ DataRecord { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataRecord1Choice_ DataRecord { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataRecord1Choice_ DataRecord { get; init; } 
    #else
    public DataRecord1Choice_ DataRecord { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the file action should be performed.
    /// ISO 8583 bit 73.
    /// </summary>
    [IsoId("_4bWuNZb7Eeuc6pwKtqbEVQ")]
    [DisplayName("Action Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnDt")]
    #endif
    [IsoXmlTag("ActnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ActionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ActionDate { get; init; } 
    #else
    public System.DateOnly? ActionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the originator of the message is authorised to update the file.
    /// ISO 8583:87 bit 92
    /// </summary>
    [IsoId("_4bWuN5b7Eeuc6pwKtqbEVQ")]
    [DisplayName("File Security Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileSctyCd")]
    #endif
    [IsoXmlTag("FileSctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FileSecurityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileSecurityCode { get; init; } 
    #else
    public System.String? FileSecurityCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
