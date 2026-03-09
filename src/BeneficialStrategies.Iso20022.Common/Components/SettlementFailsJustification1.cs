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
/// Specifies the justification for the derogation justification on the reporting of settlement fails instructions.
/// </summary>
[IsoId("_TKY2UMs0EemSav3hRKzWyg")]
[DisplayName("Settlement Fails Justification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsJustification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsJustification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsJustification1( System.UInt64 reqValue,SettlementDataRate1Choice_ reqRate )
    {
        Value = reqValue;
        Rate = reqRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the value of settlement fails, which does not exceed the limit value as specified in the local regulation.
    /// </summary>
    [IsoId("_TKY2Uss0EemSav3hRKzWyg")]
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
    
    /// <summary>
    /// Specifies the rate of settlement fails, which does not exceed the limits rate as specified in the local regulation.
    /// </summary>
    [IsoId("_TKY2U8s0EemSav3hRKzWyg")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDataRate1Choice_ Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDataRate1Choice_ Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDataRate1Choice_ Rate { get; init; } 
    #else
    public SettlementDataRate1Choice_ Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
