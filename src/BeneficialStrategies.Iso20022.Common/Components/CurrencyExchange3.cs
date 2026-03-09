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
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_QLp0Ztp-Ed-ak6NoX_4Aeg_2077728599")]
[DisplayName("Currency Exchange")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyExchange3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyExchange3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyExchange3( string reqSourceCurrency,System.Decimal reqExchangeRate )
    {
        SourceCurrency = reqSourceCurrency;
        ExchangeRate = reqExchangeRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QLzlYNp-Ed-ak6NoX_4Aeg_-2102720186")]
    [DisplayName("Source Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcy")]
    #endif
    [IsoXmlTag("SrcCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode SourceCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SourceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SourceCurrency { get; init; } 
    #else
    public string SourceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QLzlYdp-Ed-ak6NoX_4Aeg_-2102720169")]
    [DisplayName("Target Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcy")]
    #endif
    [IsoXmlTag("TrgtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? TargetCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TargetCurrency { get; init; } 
    #else
    public string? TargetCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLzlYtp-Ed-ak6NoX_4Aeg_-2102720523")]
    [DisplayName("Unit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitCcy")]
    #endif
    [IsoXmlTag("UnitCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? UnitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? UnitCurrency { get; init; } 
    #else
    public string? UnitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QLzlY9p-Ed-ak6NoX_4Aeg_-2102720481")]
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
    /// Unique and unambiguous identifier of the foreign exchange contract.
    /// </summary>
    [IsoId("_QLzlZNp-Ed-ak6NoX_4Aeg_-2102720204")]
    [DisplayName("Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctId")]
    #endif
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContractIdentification { get; init; } 
    #else
    public System.String? ContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_QLzlZdp-Ed-ak6NoX_4Aeg_-2102720246")]
    [DisplayName("Quotation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnDt")]
    #endif
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? QuotationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? QuotationDate { get; init; } 
    #else
    public System.DateTime? QuotationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
