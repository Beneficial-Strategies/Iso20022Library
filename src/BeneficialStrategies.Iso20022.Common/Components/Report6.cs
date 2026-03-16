// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_2cw6QQaUEe2-DuDrUXkg2w")]
[DisplayName("Report")]
public record Report6
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_2uWZgwaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Gives the name and the reference of the query.
    /// </summary>
    [IsoId("_2uWZhQaUEe2-DuDrUXkg2w")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    public QueryReference2? QueryReference { get; init; }

    /// <summary>
    /// Reference of the report.
    /// </summary>
    [IsoId("_2uWZhwaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReportIdentification { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_2uWZiQaUEe2-DuDrUXkg2w")]
    [DisplayName("Report Date Time")]
    [IsoXmlTag("RptDtTm")]
    public required DateAndDateTime1Choice_ ReportDateTime { get; init; }

    /// <summary>
    /// Specifies the regularity of an event.
    /// </summary>
    [IsoId("_2uWZiwaUEe2-DuDrUXkg2w")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_2uWZjQaUEe2-DuDrUXkg2w")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public StatementUpdateTypeCodeAndDSSCode1Choice_? UpdateType { get; init; }

    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_2uWZjwaUEe2-DuDrUXkg2w")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public GenericIdentification30? NoticeType { get; init; }
}
