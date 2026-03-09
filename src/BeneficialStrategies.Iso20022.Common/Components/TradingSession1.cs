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
/// The details of a specific trading session.
/// </summary>
[IsoId("_S0oo3dp-Ed-ak6NoX_4Aeg_-1794649600")]
[DisplayName("Trading Session")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradingSession1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a specific execution time bracket code through its trading session name or description.
    /// </summary>
    [IsoId("_S0oo3tp-Ed-ak6NoX_4Aeg_-1733697860")]
    [DisplayName("Trading Session Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSsnId")]
    #endif
    [IsoXmlTag("TradgSsnId")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax128Text? TradingSessionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingSessionIdentification { get; init; } 
    #else
    public System.String? TradingSessionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Optional market assigned sub identifier for a trading session. Usage is determined by market or counterparties.
    /// </summary>
    [IsoId("_S0yZ0Np-Ed-ak6NoX_4Aeg_-365329415")]
    [DisplayName("Trading Session Sub Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSsnSubId")]
    #endif
    [IsoXmlTag("TradgSsnSubId")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax128Text? TradingSessionSubIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingSessionSubIdentification { get; init; } 
    #else
    public System.String? TradingSessionSubIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
