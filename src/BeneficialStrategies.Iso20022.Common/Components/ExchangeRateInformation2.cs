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
/// Further detailed information on the exchange rate that has been used in or is related to the transaction.
/// </summary>
[IsoId("_ZGiv0INlEeuHqfO1LgkE9Q")]
[DisplayName("Exchange Rate Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeRateInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the source of the rate information.
    /// </summary>
    [IsoId("_FxfKMINmEeuHqfO1LgkE9Q")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Provider { get; init; } 
    #else
    public System.String? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the specific rate, table or file that contains the rate information.
    /// </summary>
    [IsoId("_NnqcQINmEeuHqfO1LgkE9Q")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// The date the exchange rate data is effective.
    /// </summary>
    [IsoId("_T8oaQINmEeuHqfO1LgkE9Q")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// The time the exchange rate data is effective.
    /// </summary>
    [IsoId("_Zsv-wINmEeuHqfO1LgkE9Q")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Time { get; init; } 
    #else
    public System.TimeOnly? Time { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a specific exchange rate
    /// </summary>
    [IsoId("_VjbfUINuEeuHqfO1LgkE9Q")]
    [DisplayName("Exchange Rate Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRateDtl")]
    #endif
    [IsoXmlTag("XchgRateDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeRateDetail1? ExchangeRateDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeRateDetail1? ExchangeRateDetail { get; init; } 
    #else
    public ExchangeRateDetail1? ExchangeRateDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Rate lock details.
    /// </summary>
    [IsoId("_wmRsQIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Rate Lock")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateLck")]
    #endif
    [IsoXmlTag("RateLck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateLock1? RateLock { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateLock1? RateLock { get; init; } 
    #else
    public RateLock1? RateLock { get; set; } 
    #endif
    
    
    #nullable disable
    
}
