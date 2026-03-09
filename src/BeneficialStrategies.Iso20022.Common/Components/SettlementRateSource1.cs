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
/// Specifies the components of a settlement rate source for a non delvierable trade.
/// </summary>
[IsoId("_CldIUJULEeak6e8_Fc5fQg")]
[DisplayName("Settlement Rate Source")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementRateSource1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementRateSource1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementRateSource1( System.String reqRateSource )
    {
        RateSource = reqRateSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the rate source for the non deliverable trade.
    /// </summary>
    [IsoId("_6mn-oJUMEeak6e8_Fc5fQg")]
    [DisplayName("Rate Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateSrc")]
    #endif
    [IsoXmlTag("RateSrc")]
    [IsoSimpleType(IsoSimpleType.RateSourceText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRateSourceText RateSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RateSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RateSource { get; init; } 
    #else
    public System.String RateSource { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time &quot;HHMM&quot; associated with the rate source.
    /// </summary>
    [IsoId("_UdWPkJUOEeak6e8_Fc5fQg")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Time { get; init; } 
    #else
    public System.String? Time { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the country code for the quoted rate source.
    /// </summary>
    [IsoId("_ISDz4JUNEeak6e8_Fc5fQg")]
    [DisplayName("Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryCd")]
    #endif
    [IsoXmlTag("CtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryCode { get; init; } 
    #else
    public string? CountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// The location expressed as a 2 character code.
    /// </summary>
    [IsoId("_1wrG4JUNEeak6e8_Fc5fQg")]
    [DisplayName("Location Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCd")]
    #endif
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2AlphaNumericText? LocationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocationCode { get; init; } 
    #else
    public System.String? LocationCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
