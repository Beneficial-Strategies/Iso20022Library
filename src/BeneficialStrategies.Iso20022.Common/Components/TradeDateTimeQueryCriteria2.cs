// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time query criteria.
/// </summary>
[IsoId("_aPgSUdGREeaQk737TH1Fzw")]
[DisplayName("Trade Date Time Query Criteria")]
public record TradeDateTimeQueryCriteria2
{
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    [IsoId("_aYTB8dGREeaQk737TH1Fzw")]
    [DisplayName("Reporting Date Time")]
    [IsoXmlTag("RptgDtTm")]
    public DateTimePeriod1? ReportingDateTime { get; init; }

    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    [IsoId("_aYTB89GREeaQk737TH1Fzw")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    public DateTimePeriod1? ExecutionDateTime { get; init; }

    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    [IsoId("_aYTB9dGREeaQk737TH1Fzw")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; }

    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    [IsoId("_aYTB99GREeaQk737TH1Fzw")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public DateOrBlankQuery2Choice_? TerminationDate { get; init; }
}
