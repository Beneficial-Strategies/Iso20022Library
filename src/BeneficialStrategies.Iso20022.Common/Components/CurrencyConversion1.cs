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
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
/// </summary>
[IsoId("_WaxKUEerEeODR7vDcYOqmg")]
[DisplayName("Currency Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyConversion1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyConversion1( CurrencyConversionResponse1Code reqResult,string reqTargetCurrency,System.String reqTargetCurrencyNumeric,System.UInt64 reqTargetCurrencyDecimal,ImpliedCurrencyAndAmount reqResultingAmount,System.Decimal reqExchangeRate,string reqSourceCurrency,System.UInt64 reqSourceCurrencyDecimal,ImpliedCurrencyAndAmount reqOriginalAmount )
    {
        Result = reqResult;
        TargetCurrency = reqTargetCurrency;
        TargetCurrencyNumeric = reqTargetCurrencyNumeric;
        TargetCurrencyDecimal = reqTargetCurrencyDecimal;
        ResultingAmount = reqResultingAmount;
        ExchangeRate = reqExchangeRate;
        SourceCurrency = reqSourceCurrency;
        SourceCurrencyDecimal = reqSourceCurrencyDecimal;
        OriginalAmount = reqOriginalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_iZT_8EerEeODR7vDcYOqmg")]
    [DisplayName("Currency Conversion Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsId")]
    #endif
    [IsoXmlTag("CcyConvsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CurrencyConversionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrencyConversionIdentification { get; init; } 
    #else
    public System.String? CurrencyConversionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_7B4bsEesEeODR7vDcYOqmg")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyConversionResponse1Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyConversionResponse1Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversionResponse1Code Result { get; init; } 
    #else
    public CurrencyConversionResponse1Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_BE5HAEetEeODR7vDcYOqmg")]
    [DisplayName("Response Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRsn")]
    #endif
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResponseReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseReason { get; init; } 
    #else
    public System.String? ResponseReason { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_HGQMgEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcy")]
    #endif
    [IsoXmlTag("TrgtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode TargetCurrency { get; init; } 
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
    [IsoId("_R98u0EetEeODR7vDcYOqmg")]
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
    /// Maximal number of digits after the decimal separator for target currency.
    /// </summary>
    [IsoId("_W5SncEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency Decimal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcyDcml")]
    #endif
    [IsoXmlTag("TrgtCcyDcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TargetCurrencyDecimal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TargetCurrencyDecimal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TargetCurrencyDecimal { get; init; } 
    #else
    public System.UInt64 TargetCurrencyDecimal { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the target currency.
    /// </summary>
    [IsoId("_eAabIEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcyNm")]
    #endif
    [IsoXmlTag("TrgtCcyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TargetCurrencyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TargetCurrencyName { get; init; } 
    #else
    public System.String? TargetCurrencyName { get; set; } 
    #endif
    
    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_l_aSAEetEeODR7vDcYOqmg")]
    [DisplayName("Resulting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgAmt")]
    #endif
    [IsoXmlTag("RsltgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ResultingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_qOWXoEetEeODR7vDcYOqmg")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_wIbJYEetEeODR7vDcYOqmg")]
    [DisplayName("Inverted Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NvrtdXchgRate")]
    #endif
    [IsoXmlTag("NvrtdXchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InvertedExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InvertedExchangeRate { get; init; } 
    #else
    public System.Decimal? InvertedExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_6I698EetEeODR7vDcYOqmg")]
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
    
    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("__syPIEetEeODR7vDcYOqmg")]
    [DisplayName("Valid Until")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldUntil")]
    #endif
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ValidUntil { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ValidUntil { get; init; } 
    #else
    public System.DateTime? ValidUntil { get; set; } 
    #endif
    
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_GMGb8EeuEeODR7vDcYOqmg")]
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
    /// Currency from which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_KxOM8EeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Numeric")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcyNmrc")]
    #endif
    [IsoXmlTag("SrcCcyNmrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? SourceCurrencyNumeric { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SourceCurrencyNumeric { get; init; } 
    #else
    public string? SourceCurrencyNumeric { get; set; } 
    #endif
    
    /// <summary>
    /// Maximal number of digits after the decimal separator for source currency.
    /// </summary>
    [IsoId("_RlVlEEeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Decimal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcyDcml")]
    #endif
    [IsoXmlTag("SrcCcyDcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber SourceCurrencyDecimal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 SourceCurrencyDecimal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 SourceCurrencyDecimal { get; init; } 
    #else
    public System.UInt64 SourceCurrencyDecimal { get; set; } 
    #endif
    
    /// <summary>
    /// Full name of the source currency.
    /// </summary>
    [IsoId("_YRNnMEeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcyNm")]
    #endif
    [IsoXmlTag("SrcCcyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SourceCurrencyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SourceCurrencyName { get; init; } 
    #else
    public System.String? SourceCurrencyName { get; set; } 
    #endif
    
    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_cvM1cEeuEeODR7vDcYOqmg")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount OriginalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_jvGxYEevEeODR7vDcYOqmg")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission19? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission19? CommissionDetails { get; init; } 
    #else
    public Commission19? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_WkHhUEewEeODR7vDcYOqmg")]
    [DisplayName("Mark Up Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrkUpDtls")]
    #endif
    [IsoXmlTag("MrkUpDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission18? MarkUpDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission18? MarkUpDetails { get; init; } 
    #else
    public Commission18? MarkUpDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_dbdMkEewEeODR7vDcYOqmg")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclarationDetails { get; init; } 
    #else
    public System.String? DeclarationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
