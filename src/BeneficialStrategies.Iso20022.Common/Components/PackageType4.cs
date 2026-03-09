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
/// Chunk of a software package.
/// </summary>
[IsoId("_flEsIXDUEe2MCaKO5AtGsA")]
[DisplayName("Package Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PackageType4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the software packages of which the chunk belongs.
    /// </summary>
    [IsoId("_fsSHYXDUEe2MCaKO5AtGsA")]
    [DisplayName("Package Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgId")]
    #endif
    [IsoXmlTag("PackgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? PackageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? PackageIdentification { get; init; } 
    #else
    public GenericIdentification176? PackageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Full length of software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_fsSHY3DUEe2MCaKO5AtGsA")]
    [DisplayName("Package Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgLngth")]
    #endif
    [IsoXmlTag("PackgLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? PackageLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PackageLength { get; init; } 
    #else
    public System.UInt64? PackageLength { get; set; } 
    #endif
    
    /// <summary>
    /// Place of the first following PackageBlock, beginning with 0, in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_fsSHZXDUEe2MCaKO5AtGsA")]
    [DisplayName("Offset Start")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetStart")]
    #endif
    [IsoXmlTag("OffsetStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? OffsetStart { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OffsetStart { get; init; } 
    #else
    public System.UInt64? OffsetStart { get; set; } 
    #endif
    
    /// <summary>
    /// Following place of the last following PackageBlock in the full software package identified through PackageIdentification.
    /// </summary>
    [IsoId("_fsSHZ3DUEe2MCaKO5AtGsA")]
    [DisplayName("Offset End")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffsetEnd")]
    #endif
    [IsoXmlTag("OffsetEnd")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OffsetEnd { get; init; } 
    #else
    public System.UInt64? OffsetEnd { get; set; } 
    #endif
    
    /// <summary>
    /// Consecutive slices of the full software package identified through PackageIdentification starting with first slice at the place identified with OffsetStart and ending with the last slice at the previous place identified with OffsetEnd.
    /// </summary>
    [IsoId("_fsSucXDUEe2MCaKO5AtGsA")]
    [DisplayName("Package Block")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgBlck")]
    #endif
    [IsoXmlTag("PackgBlck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternallyDefinedData4? PackageBlock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternallyDefinedData4? PackageBlock { get; init; } 
    #else
    public ExternallyDefinedData4? PackageBlock { get; set; } 
    #endif
    
    
    #nullable disable
    
}
