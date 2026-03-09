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
/// Grace period applicable to an instalment plan.
/// </summary>
[IsoId("_SDCRMEVCEeea-M6VZkEPUw")]
[DisplayName("Grace Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GracePeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GracePeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GracePeriod1( System.String reqTime,GracePeriodUnitType1Code reqUnitType )
    {
        Time = reqTime;
        UnitType = reqUnitType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Grace period time relative to the grace period unit type. 
    /// </summary>
    [IsoId("_mEDvgEVCEeea-M6VZkEPUw")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText Time { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Time { get; init; } 
    #else
    public System.String Time { get; set; } 
    #endif
    
    /// <summary>
    /// Grace period unit type.
    /// </summary>
    [IsoId("_tgcBgEVCEeea-M6VZkEPUw")]
    [DisplayName("Unit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitTp")]
    #endif
    [IsoXmlTag("UnitTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GracePeriodUnitType1Code UnitType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GracePeriodUnitType1Code UnitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GracePeriodUnitType1Code UnitType { get; init; } 
    #else
    public GracePeriodUnitType1Code UnitType { get; set; } 
    #endif
    
    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    [IsoId("_7tjAcEVCEeea-M6VZkEPUw")]
    [DisplayName("Other Unit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitTp")]
    #endif
    [IsoXmlTag("OthrUnitTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitType { get; init; } 
    #else
    public System.String? OtherUnitType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
