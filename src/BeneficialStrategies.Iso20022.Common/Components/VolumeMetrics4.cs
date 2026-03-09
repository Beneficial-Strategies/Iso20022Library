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
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
[IsoId("_T23LEIMGEeueDJg7fN5MDw")]
[DisplayName("Volume Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeMetrics4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [IsoId("_XE-s4oMGEeueDJg7fN5MDw")]
    [DisplayName("Reuse Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReuseVal")]
    #endif
    [IsoXmlTag("ReuseVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReuseValue1Choice_? ReuseValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReuseValue1Choice_? ReuseValue { get; init; } 
    #else
    public ReuseValue1Choice_? ReuseValue { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_XE-s44MGEeueDJg7fN5MDw")]
    [DisplayName("Reinvested Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstdCshAmt")]
    #endif
    [IsoXmlTag("RinvstdCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ReinvestedCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ReinvestedCashAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ReinvestedCashAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
