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
/// Specifies the details on the settlement fails per currency.
/// </summary>
[IsoId("_antbaR2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Currency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsCurrency2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsCurrency2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsCurrency2( string reqCurrency,SettlementTotalData1 reqData )
    {
        Currency = reqCurrency;
        Data = reqData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the cash counter value specified in a settlement instruction.
    /// Usage: this is the currency in which the aggregate values have to be reported for the settlement fails per currency.
    /// </summary>
    [IsoId("_ao5uMR2lEeqF2P5v-Rtejg")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregated data of all settlement transactions per currency.
    /// </summary>
    [IsoId("_ao5uMx2lEeqF2P5v-Rtejg")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementTotalData1 Data { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementTotalData1 Data { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTotalData1 Data { get; init; } 
    #else
    public SettlementTotalData1 Data { get; set; } 
    #endif
    
    
    #nullable disable
    
}
