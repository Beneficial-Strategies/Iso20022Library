// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on limit.
/// </summary>
[IsoId("_76joYqMgEeCJ6YNENx4h-w_915944242")]
[DisplayName("Limit Return Criteria")]
public partial record LimitReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the limit start date time is requested.
    /// </summary>
    [IsoId("_76joY6MgEeCJ6YNENx4h-w_1532338031")]
    [DisplayName("Start Date Time Indicator")]
    [IsoXmlTag("StartDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StartDateTimeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the limit status is requested.
    /// </summary>
    [IsoId("_76joZKMgEeCJ6YNENx4h-w_2002414441")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the limit used amount is requested.
    /// </summary>
    [IsoId("_76joZaMgEeCJ6YNENx4h-w_-611823697")]
    [DisplayName("Used Amount Indicator")]
    [IsoXmlTag("UsdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? UsedAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the limit used percentage is requested.
    /// </summary>
    [IsoId("_76joZqMgEeCJ6YNENx4h-w_1711979106")]
    [DisplayName("Used Percentage Indicator")]
    [IsoXmlTag("UsdPctgInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? UsedPercentageIndicator { get; init; } 
    
    
    #nullable disable
    
}
