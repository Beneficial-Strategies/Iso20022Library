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
/// Specifies the parameters for an Isabel payment file.
/// </summary>
[IsoId("_ji0LAMmIEeWAGphE2LvqeA")]
[DisplayName("Isabel File")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelFile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelFile1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelFile1( System.String reqIdentification,System.UInt64 reqSize,System.String reqFormat )
    {
        Identification = reqIdentification;
        Size = reqSize;
        Format = reqFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the file.	.
    /// </summary>
    [IsoId("_rZhBgMmIEeWAGphE2LvqeA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max14AlphaNumericText)]
    [StringLength(maximumLength: 14 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax14AlphaNumericText Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the originator of the file.
    /// </summary>
    [IsoId("_2XvCkcmIEeWAGphE2LvqeA")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.Max14AlphaNumericText)]
    [StringLength(maximumLength: 14 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax14AlphaNumericText? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Originator { get; init; } 
    #else
    public System.String? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Size of the file.
    /// </summary>
    [IsoId("_AMHtwMmJEeWAGphE2LvqeA")]
    [DisplayName("Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sz")]
    #endif
    [IsoXmlTag("Sz")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Size { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Size { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Size { get; init; } 
    #else
    public System.UInt64 Size { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the file.
    /// </summary>
    [IsoId("_DXfdkMmJEeWAGphE2LvqeA")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text Format { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Format { get; init; } 
    #else
    public System.String Format { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the format of the file.
    /// </summary>
    [IsoId("_IjaI0MmJEeWAGphE2LvqeA")]
    [DisplayName("Format Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmtVrsn")]
    #endif
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? FormatVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FormatVersion { get; init; } 
    #else
    public System.String? FormatVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Length of the individual records in the file.
    /// </summary>
    [IsoId("_S3XE4MmJEeWAGphE2LvqeA")]
    [DisplayName("Record Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdLngth")]
    #endif
    [IsoXmlTag("RcrdLngth")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? RecordLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecordLength { get; init; } 
    #else
    public System.String? RecordLength { get; set; } 
    #endif
    
    
    #nullable disable
    
}
