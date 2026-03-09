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
/// Specifies the currency(ies) for each leg of the transaction.
/// </summary>
[IsoId("_q25Pk3hCEeu3kecHd7QKUQ")]
[DisplayName("Leg Currency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LegCurrency2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the first leg.
    /// </summary>
    [IsoId("_rFUtEXhCEeu3kecHd7QKUQ")]
    [DisplayName("Currency First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyFrstLeg")]
    #endif
    [IsoXmlTag("CcyFrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? CurrencyFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencyFirstLeg { get; init; } 
    #else
    public string? CurrencyFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_rFUtE3hCEeu3kecHd7QKUQ")]
    [DisplayName("Currency Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyScndLeg")]
    #endif
    [IsoXmlTag("CcyScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? CurrencySecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CurrencySecondLeg { get; init; } 
    #else
    public string? CurrencySecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
