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
/// ATM cassette counter per unit value or globally.
/// </summary>
[IsoId("_sVeosIqgEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette Counters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCassetteCounters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCassetteCounters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCassetteCounters1( System.UInt64 reqCurrentNumber )
    {
        CurrentNumber = reqCurrentNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of one media unit, if the media type is valued.
    /// </summary>
    [IsoId("_-kSigIqgEeS4a4abTJTSSw")]
    [DisplayName("Unit Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitVal")]
    #endif
    [IsoXmlTag("UnitVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitValue { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the media, if the media type is valued and different from the currency of the requested amount.
    /// </summary>
    [IsoId("_DeWBsIqhEeS4a4abTJTSSw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Type of notes.
    /// </summary>
    [IsoId("_kdC3YIqhEeS4a4abTJTSSw")]
    [DisplayName("Item Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmTp")]
    #endif
    [IsoXmlTag("ItmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMNoteType2Code? ItemType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMNoteType2Code? ItemType { get; init; } 
    #else
    public ATMNoteType2Code? ItemType { get; set; } 
    #endif
    
    /// <summary>
    /// Counters of media inside the cassette.
    /// </summary>
    [IsoId("_-Ib3gIqhEeS4a4abTJTSSw")]
    [DisplayName("Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntr")]
    #endif
    [IsoXmlTag("Cntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassetteCounters2? Counter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassetteCounters2? Counter { get; init; } 
    #else
    public ATMCassetteCounters2? Counter { get; set; } 
    #endif
    
    /// <summary>
    /// Current number of media present in the cassette.
    /// </summary>
    [IsoId("_u-9sEIqjEeS4a4abTJTSSw")]
    [DisplayName("Current Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurNb")]
    #endif
    [IsoXmlTag("CurNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber CurrentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 CurrentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 CurrentNumber { get; init; } 
    #else
    public System.UInt64 CurrentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Current amount in the cassette.
    /// </summary>
    [IsoId("_zbbQUIqjEeS4a4abTJTSSw")]
    [DisplayName("Current Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurAmt")]
    #endif
    [IsoXmlTag("CurAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CurrentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
