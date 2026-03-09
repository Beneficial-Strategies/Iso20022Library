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
/// Specifies time and type of contract confirmation.
/// </summary>
[IsoId("_8KV5lA27EeWmAKKPnqYEVQ")]
[DisplayName("Trade Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeConfirmation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeConfirmation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeConfirmation2( TradeConfirmationType1Code reqType,System.DateTime reqTimeStamp )
    {
        Type = reqType;
        TimeStamp = reqTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the contract was confirmed electronically or non-electronically.
    /// </summary>
    [IsoId("_8KV5lg27EeWmAKKPnqYEVQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeConfirmationType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeConfirmationType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmationType1Code Type { get; init; } 
    #else
    public TradeConfirmationType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
    /// </summary>
    [IsoId("_8KV5lQ27EeWmAKKPnqYEVQ")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
