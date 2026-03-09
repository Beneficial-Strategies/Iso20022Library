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
/// Other amount in clearing record data.
/// </summary>
[IsoId("_L8b4wZM5EeuleeHpFMMhmQ")]
[DisplayName("Other Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherAmount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherAmount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherAmount4( System.UInt64 reqClearingCount,Amount17 reqClearingAmount )
    {
        ClearingCount = reqClearingCount;
        ClearingAmount = reqClearingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of other amounts involved in clearing.
    /// </summary>
    [IsoId("_MBFvQZM5EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCnt")]
    #endif
    [IsoXmlTag("ClrCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ClearingCount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ClearingCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ClearingCount { get; init; } 
    #else
    public System.UInt64 ClearingCount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of clearing.
    /// </summary>
    [IsoId("_MBFvQ5M5EeuleeHpFMMhmQ")]
    [DisplayName("Clearing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAmt")]
    #endif
    [IsoXmlTag("ClrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount17 ClearingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount17 ClearingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17 ClearingAmount { get; init; } 
    #else
    public Amount17 ClearingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_MBFvRZM5EeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrchngFee")]
    #endif
    [IsoXmlTag("IntrchngFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount17? InterchangeFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17? InterchangeFee { get; init; } 
    #else
    public Amount17? InterchangeFee { get; set; } 
    #endif
    
    /// <summary>
    /// Agent fee.
    /// </summary>
    [IsoId("_MBFvR5M5EeuleeHpFMMhmQ")]
    [DisplayName("Agent Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtFee")]
    #endif
    [IsoXmlTag("AgtFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount17? AgentFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17? AgentFee { get; init; } 
    #else
    public Amount17? AgentFee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
