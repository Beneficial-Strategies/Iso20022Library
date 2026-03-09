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
/// Provides information about the terms of the foreign exchange transaction.
/// </summary>
[IsoId("_ASjlENokEeC60axPepSq7g_705776918")]
[DisplayName("Foreign Exchange Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTerms18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTerms18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTerms18( string reqUnitCurrency,string reqQuotedCurrency,System.Decimal reqExchangeRate,ActiveCurrencyAndAmount reqConvertedAmount )
    {
        UnitCurrency = reqUnitCurrency;
        QuotedCurrency = reqQuotedCurrency;
        ExchangeRate = reqExchangeRate;
        ConvertedAmount = reqConvertedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_ASjlEdokEeC60axPepSq7g_591937852")]
    [DisplayName("Unit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitCcy")]
    #endif
    [IsoXmlTag("UnitCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode UnitCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string UnitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string UnitCurrency { get; init; } 
    #else
    public string UnitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_AStWENokEeC60axPepSq7g_-291295435")]
    [DisplayName("Quoted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtdCcy")]
    #endif
    [IsoXmlTag("QtdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string QuotedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string QuotedCurrency { get; init; } 
    #else
    public string QuotedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.|Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_AStWEdokEeC60axPepSq7g_-405134501")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount following a foreign exchange conversion.
    /// </summary>
    [IsoId("_AStWEtokEeC60axPepSq7g_-1288367788")]
    [DisplayName("Converted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtdAmt")]
    #endif
    [IsoXmlTag("ConvtdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ConvertedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ConvertedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ConvertedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ConvertedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
