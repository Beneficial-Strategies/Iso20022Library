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
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_wx1DhcWEEeiRga8tPu1L4Q")]
[DisplayName("Position Set Value And Notional")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetValueAndNotional1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregations of all notional values of the derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_wx1Dh8WEEeiRga8tPu1L4Q")]
    [DisplayName("Notional")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntnl")]
    #endif
    [IsoXmlTag("Ntnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20Amount? Notional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20Amount? Notional { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20Amount? Notional { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregations of all values of the derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_wx1DiMWEEeiRga8tPu1L4Q")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20Amount? Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20Amount? Value { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20Amount? Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
