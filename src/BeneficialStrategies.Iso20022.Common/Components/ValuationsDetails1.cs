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
/// Valuation details for the securities position.
/// </summary>
[IsoId("_h4b_UMYeEeiSF9q-coWegA")]
[DisplayName("Valuations Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationsDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationsDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationsDetails1( CollateralAmount4 reqValuationDetailsAmount,ValuationFactorBreakdown1 reqValuationFactorBreakdown )
    {
        ValuationDetailsAmount = reqValuationDetailsAmount;
        ValuationFactorBreakdown = reqValuationFactorBreakdown;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_1mKU0MvJEeiWUeUVHQmKaw")]
    [DisplayName("Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPric")]
    #endif
    [IsoXmlTag("MktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price7? MarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price7? MarketPrice { get; init; } 
    #else
    public Price7? MarketPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Source of the price quotation.
    /// </summary>
    [IsoId("_AFnWQMvKEeiWUeUVHQmKaw")]
    [DisplayName("Source Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfPric")]
    #endif
    [IsoXmlTag("SrcOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification89? SourceOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification89? SourceOfPrice { get; init; } 
    #else
    public MarketIdentification89? SourceOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the financial instruments are to be delivered or received effectively (Effective Settlement Date and Time).
    /// </summary>
    [IsoId("_YtBAEM4KEeiirviLm7P0IA")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? SettlementDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Securities collateral position valuation amounts.
    /// </summary>
    [IsoId("_q4_dwM4JEeiirviLm7P0IA")]
    [DisplayName("Valuation Details Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDtlsAmt")]
    #endif
    [IsoXmlTag("ValtnDtlsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAmount4 ValuationDetailsAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAmount4 ValuationDetailsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount4 ValuationDetailsAmount { get; init; } 
    #else
    public CollateralAmount4 ValuationDetailsAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of interest that has been accrued in between coupon payment periods for a given financial instrument.
    /// </summary>
    [IsoId("_A_yTsTYgEeuD7rm9md9zvg")]
    [DisplayName("Accrued Interest")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrst")]
    #endif
    [IsoXmlTag("AcrdIntrst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterest { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterest { get; set; } 
    #endif
    
    /// <summary>
    /// Price amount excluding the accrued interest for a given financial instrument.
    /// </summary>
    [IsoId("_MfnNATYgEeuD7rm9md9zvg")]
    [DisplayName("Clean Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CleanPric")]
    #endif
    [IsoXmlTag("CleanPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? CleanPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? CleanPrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? CleanPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation factors.
    /// </summary>
    [IsoId("_t-xx0DYoEeuD7rm9md9zvg")]
    [DisplayName("Valuation Factor Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnFctrBrkdwn")]
    #endif
    [IsoXmlTag("ValtnFctrBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationFactorBreakdown1 ValuationFactorBreakdown { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationFactorBreakdown1 ValuationFactorBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationFactorBreakdown1 ValuationFactorBreakdown { get; init; } 
    #else
    public ValuationFactorBreakdown1 ValuationFactorBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_jGmV8M39EeiirviLm7P0IA")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days since the last pricing update.
    /// </summary>
    [IsoId("_QWBWYM3-EeiirviLm7P0IA")]
    [DisplayName("Quotation Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnAge")]
    #endif
    [IsoXmlTag("QtnAge")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? QuotationAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? QuotationAge { get; init; } 
    #else
    public System.UInt64? QuotationAge { get; set; } 
    #endif
    
    
    #nullable disable
    
}
