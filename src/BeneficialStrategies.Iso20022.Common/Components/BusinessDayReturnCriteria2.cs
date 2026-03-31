// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on business day information.
/// </summary>
[IsoId("_75XVlqMgEeCJ6YNENx4h-w_-59874421")]
[DisplayName("Business Day Return Criteria")]
public record BusinessDayReturnCriteria2
{
    /// <summary>
    /// Indicates whether the system date is requested.
    /// </summary>
    [IsoId("_75XVl6MgEeCJ6YNENx4h-w_-1794151342")]
    [DisplayName("System Date Indicator")]
    [IsoXmlTag("SysDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SystemDateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the system status is requested.
    /// </summary>
    [IsoId("_75XVmKMgEeCJ6YNENx4h-w_-173713487")]
    [DisplayName("System Status Indicator")]
    [IsoXmlTag("SysStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SystemStatusIndicator { get; init; }

    /// <summary>
    /// Indicates whether the system currency is requested.
    /// </summary>
    [IsoId("_75XVmaMgEeCJ6YNENx4h-w_-734965435")]
    [DisplayName("System Currency Indicator")]
    [IsoXmlTag("SysCcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SystemCurrencyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the closure information is requested.
    /// </summary>
    [IsoId("_75gfgKMgEeCJ6YNENx4h-w_1130036750")]
    [DisplayName("Closure Period Indicator")]
    [IsoXmlTag("ClsrPrdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ClosurePeriodIndicator { get; init; }

    /// <summary>
    /// Indicates whether the events are requested.
    /// </summary>
    [IsoId("_75gfgaMgEeCJ6YNENx4h-w_-1170785840")]
    [DisplayName("Event Indicator")]
    [IsoXmlTag("EvtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EventIndicator { get; init; }

    /// <summary>
    /// Indicates whether the session period is requested.
    /// </summary>
    [IsoId("_75gfgqMgEeCJ6YNENx4h-w_2127109103")]
    [DisplayName("Session Period Indicator")]
    [IsoXmlTag("SsnPrdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SessionPeriodIndicator { get; init; }

    /// <summary>
    /// Indicates whether the system event type is requested.
    /// </summary>
    [IsoId("_75gfg6MgEeCJ6YNENx4h-w_-1854786731")]
    [DisplayName("Event Type Indicator")]
    [IsoXmlTag("EvtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EventTypeIndicator { get; init; }
}
