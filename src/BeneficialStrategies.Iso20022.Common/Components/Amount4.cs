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
/// Amount, currency, exchange rate and quotation date.
/// </summary>
[IsoId("_shQi4ESGEeeb1MmUPTrSMw")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount4( ImpliedCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_H_0w0ESHEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code associated with the applicable type of amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_P33rIESHEeeb1MmUPTrSMw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// The factor used in the conversion from one amount to another amount.
    /// </summary>
    [IsoId("_0rnfwESHEeeb1MmUPTrSMw")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ExchangeRate { get; init; } 
    #else
    public System.UInt64? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_8tPM0ESHEeeb1MmUPTrSMw")]
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
