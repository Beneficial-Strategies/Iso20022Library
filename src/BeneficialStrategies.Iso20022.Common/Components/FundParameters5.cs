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
/// Parameters required to request a fund reference data report.
/// </summary>
[IsoId("_KQMXEWomEeipaMTLlhaKMQ")]
[DisplayName("Fund Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundParameters5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial instrument for which the report is requested.
    /// </summary>
    [IsoId("_Kf9RY2omEeipaMTLlhaKMQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument71? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument71? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument71? FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Fund management company for which the report is requested.
    /// </summary>
    [IsoId("_Kf9RZWomEeipaMTLlhaKMQ")]
    [DisplayName("Fund Management Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndMgmtCpny")]
    #endif
    [IsoXmlTag("FndMgmtCpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? FundManagementCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? FundManagementCompany { get; init; } 
    #else
    public PartyIdentification139? FundManagementCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on or after which the information required will have been last updated. Only the most recent versions of the data is required.
    /// </summary>
    [IsoId("_Kf9RZ2omEeipaMTLlhaKMQ")]
    [DisplayName("Date From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtFr")]
    #endif
    [IsoXmlTag("DtFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateFrom { get; init; } 
    #else
    public System.DateOnly? DateFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    [IsoId("_Kf9RaWomEeipaMTLlhaKMQ")]
    [DisplayName("Country Of Domicile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfDmcl")]
    #endif
    [IsoXmlTag("CtryOfDmcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfDomicile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfDomicile { get; init; } 
    #else
    public string? CountryOfDomicile { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    [IsoId("_Kf9Ra2omEeipaMTLlhaKMQ")]
    [DisplayName("Registered Distribution Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdDstrbtnCtry")]
    #endif
    [IsoXmlTag("RegdDstrbtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RegisteredDistributionCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RegisteredDistributionCountry { get; init; } 
    #else
    public string? RegisteredDistributionCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
