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
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
[IsoId("_XaIX6fWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerRecord3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_XaIX7_WfEemtd4wHZYvFUQ")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_XaIX8fWfEemtd4wHZYvFUQ")]
    [DisplayName("Exchange Rate Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateData")]
    #endif
    [IsoXmlTag("XchgRateData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange16? ExchangeRateData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange16? ExchangeRateData { get; init; } 
    #else
    public CurrencyExchange16? ExchangeRateData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
