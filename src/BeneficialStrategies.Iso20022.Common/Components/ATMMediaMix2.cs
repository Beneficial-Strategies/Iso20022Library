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
/// Media mix selected.
/// </summary>
[IsoId("_SOOfEYq4EeSIDtZ76p6McQ")]
[DisplayName("ATM Media Mix")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMMediaMix2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMMediaMix2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMMediaMix2( System.UInt64 reqNumber,ImpliedCurrencyAndAmount reqUnitValue )
    {
        Number = reqNumber;
        UnitValue = reqUnitValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of notes or coins.
    /// </summary>
    [IsoId("_SbVuA4q4EeSIDtZ76p6McQ")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Number { get; init; } 
    #else
    public System.UInt64 Number { get; set; } 
    #endif
    
    /// <summary>
    /// Unit value.
    /// </summary>
    [IsoId("_SbVuBYq4EeSIDtZ76p6McQ")]
    [DisplayName("Unit Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitVal")]
    #endif
    [IsoXmlTag("UnitVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount UnitValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount UnitValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount UnitValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount UnitValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
