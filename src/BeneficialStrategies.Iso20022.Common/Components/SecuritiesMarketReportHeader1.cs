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
/// Provides the securities market transaction report related header details.
/// </summary>
[IsoId("_Xt9fc8v5EeSxLrW9hropkQ")]
[DisplayName("Securities Market Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesMarketReportHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesMarketReportHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesMarketReportHeader1( TradingVenueIdentification1Choice_ reqReportingEntity,Period4Choice_ reqReportingPeriod )
    {
        ReportingEntity = reqReportingEntity;
        ReportingPeriod = reqReportingPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the venue which generates the report.
    /// </summary>
    [IsoId("_Xt9fdcv5EeSxLrW9hropkQ")]
    [DisplayName("Reporting Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgNtty")]
    #endif
    [IsoXmlTag("RptgNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingVenueIdentification1Choice_ ReportingEntity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingVenueIdentification1Choice_ ReportingEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingVenueIdentification1Choice_ ReportingEntity { get; init; } 
    #else
    public TradingVenueIdentification1Choice_ ReportingEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_BlHMcjd6EeWebbGLlGzH3g")]
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
    /// Date and time of the report originally submitted by the reporting entity when the file is generated for submission to their reporting authority.
    /// </summary>
    [IsoId("_g6lmcL4BEeWvRsMSLyTf-A")]
    [DisplayName("Submission Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmissnDtTm")]
    #endif
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SubmissionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SubmissionDateTime { get; init; } 
    #else
    public System.DateTime? SubmissionDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
