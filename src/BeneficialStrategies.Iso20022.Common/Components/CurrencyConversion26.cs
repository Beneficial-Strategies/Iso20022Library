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
[IsoId("_3dNVAXDLEe2MCaKO5AtGsA")]
[DisplayName("Currency Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyConversion26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyConversion26( CurrencyDetails3 reqTargetCurrency,System.Decimal reqExchangeRate,CurrencyDetails2 reqSourceCurrency )
    {
        TargetCurrency = reqTargetCurrency;
        ExchangeRate = reqExchangeRate;
        SourceCurrency = reqSourceCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_3kXF4XDLEe2MCaKO5AtGsA")]
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
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_3kXF43DLEe2MCaKO5AtGsA")]
    [DisplayName("Target Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtCcy")]
    #endif
    [IsoXmlTag("TrgtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyDetails3 TargetCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyDetails3 TargetCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDetails3 TargetCurrency { get; init; } 
    #else
    public CurrencyDetails3 TargetCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_3kXF5XDLEe2MCaKO5AtGsA")]
    [DisplayName("Resulting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgAmt")]
    #endif
    [IsoXmlTag("RsltgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ResultingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ResultingAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ResultingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_3kXF53DLEe2MCaKO5AtGsA")]
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
    [IsoId("_3kXF6XDLEe2MCaKO5AtGsA")]
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
    [IsoId("_3kXF63DLEe2MCaKO5AtGsA")]
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
    /// Specifies when the currency conversion could start.
    /// </summary>
    [IsoId("_7ysSEHDMEe2MCaKO5AtGsA")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ValidFrom { get; init; } 
    #else
    public System.DateTime? ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_3kYUAXDLEe2MCaKO5AtGsA")]
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
    [IsoId("_3kYUA3DLEe2MCaKO5AtGsA")]
    [DisplayName("Source Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcCcy")]
    #endif
    [IsoXmlTag("SrcCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyDetails2 SourceCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyDetails2 SourceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDetails2 SourceCurrency { get; init; } 
    #else
    public CurrencyDetails2 SourceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Range of Bin for which the conversion is possible.
    /// </summary>
    [IsoId("_v_oeQHDNEe2MCaKO5AtGsA")]
    [DisplayName("Applicable Bin Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblBinRg")]
    #endif
    [IsoXmlTag("AplblBinRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BinRange1? ApplicableBinRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BinRange1? ApplicableBinRange { get; init; } 
    #else
    public BinRange1? ApplicableBinRange { get; set; } 
    #endif
    
    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_3kYUBXDLEe2MCaKO5AtGsA")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalAmountDetails1? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalAmountDetails1? OriginalAmount { get; init; } 
    #else
    public OriginalAmountDetails1? OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_3kYUB3DLEe2MCaKO5AtGsA")]
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
    [IsoId("_3kYUCXDLEe2MCaKO5AtGsA")]
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
    [IsoId("_3kYUC3DLEe2MCaKO5AtGsA")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? DeclarationDetails { get; init; } 
    #else
    public ActionMessage10? DeclarationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
