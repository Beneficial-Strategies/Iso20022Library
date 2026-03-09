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
/// Exchange rate and calculated amount to be presented to the customer when the dispense currency or the deposit currency (target currency) is different to account currency (source currency).
/// </summary>
[IsoId("_S77gUYq9EeSHjtO_wHA7PQ")]
[DisplayName("Currency Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyConversion5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyConversion5( string reqSourceCurrency,string reqSourceCurrencyNumeric,string reqTargetCurrency,System.String reqTargetCurrencyNumeric,System.Decimal reqRate,ImpliedCurrencyAndAmount reqCalculatedAmount )
    {
        SourceCurrency = reqSourceCurrency;
        SourceCurrencyNumeric = reqSourceCurrencyNumeric;
        TargetCurrency = reqTargetCurrency;
        TargetCurrencyNumeric = reqTargetCurrencyNumeric;
        Rate = reqRate;
        CalculatedAmount = reqCalculatedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_TH_mbYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Source Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcy")]
    #endif
    [IsoXmlTag("SrcCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SourceCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SourceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SourceCurrency { get; init; } 
    #else
    public string SourceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_TH_mb4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Source Currency Numeric")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcyNmrc")]
    #endif
    [IsoXmlTag("SrcCcyNmrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SourceCurrencyNumeric { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SourceCurrencyNumeric { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SourceCurrencyNumeric { get; init; } 
    #else
    public string SourceCurrencyNumeric { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_TH2cd4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Target Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcy")]
    #endif
    [IsoXmlTag("TrgtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode TargetCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string TargetCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string TargetCurrency { get; init; } 
    #else
    public string TargetCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_TH2ceYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Target Currency Numeric")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcyNmrc")]
    #endif
    [IsoXmlTag("TrgtCcyNmrc")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText TargetCurrencyNumeric { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TargetCurrencyNumeric { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TargetCurrencyNumeric { get; init; } 
    #else
    public System.String TargetCurrencyNumeric { get; set; } 
    #endif
    
    /// <summary>
    /// Currency exchange rate.
    /// </summary>
    [IsoId("_TH_mZYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting calculated amount is in target currency.
    /// </summary>
    [IsoId("_TH_mY4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Calculated Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctdAmt")]
    #endif
    [IsoXmlTag("ClctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount CalculatedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount CalculatedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount CalculatedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount CalculatedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
