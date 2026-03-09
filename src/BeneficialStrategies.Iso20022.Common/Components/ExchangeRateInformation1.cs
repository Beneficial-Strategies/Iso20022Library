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
/// Further detailed information on the exchange rate that has been used in the payment transaction.
/// </summary>
[IsoId("_QLp0Ytp-Ed-ak6NoX_4Aeg_-1204184302")]
[DisplayName("Exchange Rate Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeRateInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_QLp0Y9p-Ed-ak6NoX_4Aeg_-940984267")]
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
    /// Specifies the type used to complete the currency exchange.
    /// </summary>
    [IsoId("_QLp0ZNp-Ed-ak6NoX_4Aeg_-940984241")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateType1Code? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateType1Code? RateType { get; init; } 
    #else
    public ExchangeRateType1Code? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.
    /// </summary>
    [IsoId("_QLp0Zdp-Ed-ak6NoX_4Aeg_-941904256")]
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
    
    
    #nullable disable
    
}
