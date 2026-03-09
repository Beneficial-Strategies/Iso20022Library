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
/// Details of the exchange rate.
/// </summary>
[IsoId("_g9N7sINmEeuHqfO1LgkE9Q")]
[DisplayName("Exchange Rate Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeRateDetail1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the party to which this detail applies.
    /// </summary>
    [IsoId("_50VUUINoEeuHqfO1LgkE9Q")]
    [DisplayName("End Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndPt")]
    #endif
    [IsoXmlTag("EndPt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Endpoint1Code? EndPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Endpoint1Code? EndPoint { get; init; } 
    #else
    public Endpoint1Code? EndPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Other nationally or privately defined endpoint.
    /// </summary>
    [IsoId("_JQ4h4INpEeuHqfO1LgkE9Q")]
    [DisplayName("Other End Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrEndPt")]
    #endif
    [IsoXmlTag("OthrEndPt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherEndPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherEndPoint { get; init; } 
    #else
    public System.String? OtherEndPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the counter currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_ZXsNYINpEeuHqfO1LgkE9Q")]
    [DisplayName("Counter Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrCcyCd")]
    #endif
    [IsoXmlTag("CntrCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? CounterCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CounterCurrencyCode { get; init; } 
    #else
    public string? CounterCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the base currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_jZtE4INpEeuHqfO1LgkE9Q")]
    [DisplayName("Base Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcyCd")]
    #endif
    [IsoXmlTag("BaseCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? BaseCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BaseCurrencyCode { get; init; } 
    #else
    public string? BaseCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the exchange rate.
    /// </summary>
    [IsoId("_zRp4MINtEeuHqfO1LgkE9Q")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOne25Rate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOne25Rate? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Rate { get; init; } 
    #else
    public System.Decimal? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of rate.
    /// </summary>
    [IsoId("_bcFjQIZ4EeuA-bTtGHZqdg")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateType2Code? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateType2Code? RateType { get; init; } 
    #else
    public ExchangeRateType2Code? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of rate defined privately or at national level.
    /// </summary>
    [IsoId("_PHyqoIZ5EeuSbct6WWD-Ng")]
    [DisplayName("Other Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRateTp")]
    #endif
    [IsoXmlTag("OthrRateTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherRateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherRateType { get; init; } 
    #else
    public System.String? OtherRateType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of exchange rate agreement.
    /// </summary>
    [IsoId("_M4vHMIZ7EeuSbct6WWD-Ng")]
    [DisplayName("Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtTp")]
    #endif
    [IsoXmlTag("AgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateAgreementType1Code? AgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateAgreementType1Code? AgreementType { get; init; } 
    #else
    public ExchangeRateAgreementType1Code? AgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of exchange rate agreement.
    /// </summary>
    [IsoId("_VgLeIIZ7EeuSbct6WWD-Ng")]
    [DisplayName("Other Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAgrmtTp")]
    #endif
    [IsoXmlTag("OthrAgrmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAgreementType { get; init; } 
    #else
    public System.String? OtherAgreementType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
