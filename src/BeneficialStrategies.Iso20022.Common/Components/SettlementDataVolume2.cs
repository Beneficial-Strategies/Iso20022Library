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
/// Aggregated values and volumes of settlements instructions for a specific type of financial instruments, type of transaction, type of clients, and cash transfers.
/// </summary>
[IsoId("_rv5NIY0SEemUAO64Q252gQ")]
[DisplayName("Settlement Data Volume")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDataVolume2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDataVolume2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDataVolume2( System.UInt64 reqVolume,System.UInt64 reqValue )
    {
        Volume = reqVolume;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the aggregated volume of settlement instructions, in terms of failed, settled transactions and total transactions.
    /// </summary>
    [IsoId("_r1TRkY0SEemUAO64Q252gQ")]
    [DisplayName("Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vol")]
    #endif
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber Volume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Volume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Volume { get; init; } 
    #else
    public System.UInt64 Volume { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the aggregated value of settlement instructions, in terms of failed, settled transactions and total transactions.
    /// </summary>
    [IsoId("_r1TRk40SEemUAO64Q252gQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveDecimalNumber Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Value { get; init; } 
    #else
    public System.UInt64 Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
