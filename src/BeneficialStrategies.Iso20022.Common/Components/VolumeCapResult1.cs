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
/// Specifies the details of result of a volume capping.
/// </summary>
[IsoId("_U7tWsJuJEeaPcol5ibnfBQ")]
[DisplayName("Volume Cap Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeCapResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VolumeCapResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VolumeCapResult1( System.String reqIdentification,Period4Choice_ reqReportingPeriod,ActiveCurrencyAndAmount reqTotalTradingVolume,System.Decimal reqTradingUnderWaiverPercentage )
    {
        Identification = reqIdentification;
        ReportingPeriod = reqReportingPeriod;
        TotalTradingVolume = reqTotalTradingVolume;
        TradingUnderWaiverPercentage = reqTradingUnderWaiverPercentage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_9ch6AJuJEeaPcol5ibnfBQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_FV0KcJuKEeaPcol5ibnfBQ")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4Choice_ ReportingPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4Choice_ ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_ ReportingPeriod { get; init; } 
    #else
    public Period4Choice_ ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Last date for which the data was updated for this instrument and reporting period.
    /// </summary>
    [IsoId("_LBukYJuKEeaPcol5ibnfBQ")]
    [DisplayName("Last Update Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdDt")]
    #endif
    [IsoXmlTag("LastUpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastUpdateDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastUpdateDate { get; init; } 
    #else
    public System.DateOnly? LastUpdateDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total traded volume of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_V17t0JuKEeaPcol5ibnfBQ")]
    [DisplayName("Total Trading Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlTradgVol")]
    #endif
    [IsoXmlTag("TtlTradgVol")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalTradingVolume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalTradingVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalTradingVolume { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalTradingVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Total percentage of trading under waiver of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_6AHBAJuKEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgUdrWvrPctg")]
    #endif
    [IsoXmlTag("TradgUdrWvrPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate TradingUnderWaiverPercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal TradingUnderWaiverPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TradingUnderWaiverPercentage { get; init; } 
    #else
    public System.Decimal TradingUnderWaiverPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of trading under waiver of the instrument in this specific reporting period broken down by trading venue.
    /// </summary>
    [IsoId("_dyll4JuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgUdrWvrBrkdwn")]
    #endif
    [IsoXmlTag("TradgUdrWvrBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingUnderWaiversPercentage1? TradingUnderWaiverBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingUnderWaiversPercentage1? TradingUnderWaiverBreakdown { get; init; } 
    #else
    public TradingUnderWaiversPercentage1? TradingUnderWaiverBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Information for interpreting the result.
    /// </summary>
    [IsoId("_JNG6MJuMEeaPcol5ibnfBQ")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Disclaimer { get; init; } 
    #else
    public System.String? Disclaimer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
