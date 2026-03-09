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
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_UcDvsbppEea_jI1vMH_RbA")]
[DisplayName("Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyExchange10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the cross currency, if different from the currency of delivery.
    /// </summary>
    [IsoId("_Ul5BI7ppEea_jI1vMH_RbA")]
    [DisplayName("Deliverable Cross Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrblCrossCcy")]
    #endif
    [IsoXmlTag("DlvrblCrossCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? DeliverableCrossCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DeliverableCrossCurrency { get; init; } 
    #else
    public string? DeliverableCrossCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Ul5BJbppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Forward exchange rate as agreed between the counterparties in the contractual agreement, expressed as a price of base currency in the quoted currency.
    /// </summary>
    [IsoId("_Ul5BJ7ppEea_jI1vMH_RbA")]
    [DisplayName("Forward Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdXchgRate")]
    #endif
    [IsoXmlTag("FwdXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ForwardExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ForwardExchangeRate { get; init; } 
    #else
    public System.Decimal? ForwardExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the quote base for the exchange rate.
    /// </summary>
    [IsoId("_Ul5BKbppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateBsis")]
    #endif
    [IsoXmlTag("XchgRateBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; init; } 
    #else
    public ExchangeRateBasis1Choice_? ExchangeRateBasis { get; set; } 
    #endif
    
    
    #nullable disable
    
}
