// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the money market statistical status report header details.
/// </summary>
[IsoId("_olkndNjLEeSD0e0ybx5L5Q")]
[DisplayName("Money Market Status Report Header")]
public record MoneyMarketStatusReportHeader1
{
    /// <summary>
    /// Agent which is subject to reporting requirements.
    /// </summary>
    [IsoId("_oluYcNjLEeSD0e0ybx5L5Q")]
    [DisplayName("Reporting Agent")]
    [IsoXmlTag("RptgAgt")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ReportingAgent { get; init; }

    /// <summary>
    /// For daily reporting this is the day to which the transaction data in the status message refers (trade date or amendment date if there are corrections).
    /// For periodic reporting this is the first and the last day to which the transaction data in the status message refers (trade date or amendment date in case of corrections).
    /// </summary>
    [IsoId("_oluYctjLEeSD0e0ybx5L5Q")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required DateTimePeriod1 ReportingPeriod { get; init; }

    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_oluYcdjLEeSD0e0ybx5L5Q")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public required StatisticalReportingStatus1Code ReportStatus { get; init; }

    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_Bqe1sd7HEeSaBeqd_btViQ")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public GenericValidationRuleIdentification1? ValidationRule { get; init; }
}
