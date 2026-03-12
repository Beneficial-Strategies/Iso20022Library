// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the securities market transaction report related header details.
/// </summary>
[IsoId("_Xt9fc8v5EeSxLrW9hropkQ")]
[DisplayName("Securities Market Report Header")]
public partial record SecuritiesMarketReportHeader1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the venue which generates the report.
    /// </summary>
    [IsoId("_Xt9fdcv5EeSxLrW9hropkQ")]
    [DisplayName("Reporting Entity")]
    [IsoXmlTag("RptgNtty")]
    public required TradingVenueIdentification1Choice_ ReportingEntity { get; init; } 
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_BlHMcjd6EeWebbGLlGzH3g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required Period4Choice_ ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Date and time of the report originally submitted by the reporting entity when the file is generated for submission to their reporting authority.
    /// </summary>
    [IsoId("_g6lmcL4BEeWvRsMSLyTf-A")]
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? SubmissionDateTime { get; init; } 
    
    
    #nullable disable
    
}
