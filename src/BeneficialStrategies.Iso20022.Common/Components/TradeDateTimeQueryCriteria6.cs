// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Date Time Query Criteria6.
/// </summary>
[IsoId("_g64wkfrhEe2mU4Wi2q3MzQ")]
[DisplayName("Trade Date Time Query Criteria6")]
public record TradeDateTimeQueryCriteria6
{
    /// <summary>
    /// Collateral Time Stamp.
    /// </summary>
    [DisplayName("Collateral Time Stamp")]
    [IsoXmlTag("CollTmStmp")]
    public DateTimeOrBlankQuery1Choice_? CollateralTimeStamp { get; init; }

    /// <summary>
    /// Early Termination Date.
    /// </summary>
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    public DatePeriod1? EarlyTerminationDate { get; init; }

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DatePeriod1? EffectiveDate { get; init; }

    /// <summary>
    /// Execution Date Time.
    /// </summary>
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    public DateTimePeriod1? ExecutionDateTime { get; init; }

    /// <summary>
    /// Expiration Date.
    /// </summary>
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public DateOrBlankQuery2Choice_? ExpirationDate { get; init; }

    /// <summary>
    /// Historical As Of Date.
    /// </summary>
    [DisplayName("Historical As Of Date")]
    [IsoXmlTag("HstrclAsOfDt")]
    public IsoISODate? HistoricalAsOfDate { get; init; }

    /// <summary>
    /// Maturity Date.
    /// </summary>
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; }

    /// <summary>
    /// Reporting Date Time.
    /// </summary>
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    public DateTimePeriod1? ReportingDateTime { get; init; }

    /// <summary>
    /// Valuation Date Time.
    /// </summary>
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    public DateTimePeriod1? ValuationDateTime { get; init; }
}
