// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the money market statistical report instrument related header details.
/// </summary>
[IsoId("_MVvycJfiEeSfnc-VXAEapg")]
[DisplayName("Money Market Report Header")]
public record MoneyMarketReportHeader1
{
    /// <summary>
    /// Agent which is subject to reporting requirements.
    /// </summary>
    [IsoId("_ziweIJfaEeS92bWS8Fjfig")]
    [DisplayName("Reporting Agent")]
    [IsoXmlTag("RptgAgt")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ReportingAgent { get; init; }

    /// <summary>
    /// Beginning and ending date-time to which the transaction data refers (trade date in case of new transactions and date of amendment in case of revisions).
    /// </summary>
    [IsoId("_WRwIkZfiEeSfnc-VXAEapg")]
    [DisplayName("Reference Period")]
    [IsoXmlTag("RefPrd")]
    public required DateTimePeriod1 ReferencePeriod { get; init; }
}
