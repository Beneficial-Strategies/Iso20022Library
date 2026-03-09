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
/// Characteristics of a hardware memory module.
/// </summary>
[IsoId("_V7AH8Ax0EeKa_56Jbsi1RQ")]
[DisplayName("Memory Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MemoryCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MemoryCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MemoryCharacteristics1( System.String reqIdentification,System.UInt64 reqTotalSize,System.UInt64 reqFreeSize,MemoryUnit1Code reqUnit )
    {
        Identification = reqIdentification;
        TotalSize = reqTotalSize;
        FreeSize = reqFreeSize;
        Unit = reqUnit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification or name of the memory.
    /// </summary>
    [IsoId("_gEGe4Ax0EeKa_56Jbsi1RQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Total size of the memory unit.
    /// </summary>
    [IsoId("_mRenIAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Total Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSz")]
    #endif
    [IsoXmlTag("TtlSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber TotalSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalSize { get; init; } 
    #else
    public System.UInt64 TotalSize { get; set; } 
    #endif
    
    /// <summary>
    /// Total size of the available memory.
    /// </summary>
    [IsoId("_sxTKQAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Free Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FreeSz")]
    #endif
    [IsoXmlTag("FreeSz")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber FreeSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 FreeSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 FreeSize { get; init; } 
    #else
    public System.UInt64 FreeSize { get; set; } 
    #endif
    
    /// <summary>
    /// Memory unit of the sizes.
    /// </summary>
    [IsoId("_344isAx0EeKa_56Jbsi1RQ")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemoryUnit1Code Unit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemoryUnit1Code Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemoryUnit1Code Unit { get; init; } 
    #else
    public MemoryUnit1Code Unit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
