// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information.
/// </summary>
[IsoId("_wW8KkUKNEeW5mJpUa0D_fg")]
[DisplayName("Statement")]
public record Statement47
{
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_wt2Os0KNEeW5mJpUa0D_fg")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType1Code StatementType { get; init; }

    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_wt2OtUKNEeW5mJpUa0D_fg")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; }

    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_wt2Ot0KNEeW5mJpUa0D_fg")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_wt2OuUKNEeW5mJpUa0D_fg")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_wt2OwUKNEeW5mJpUa0D_fg")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_wt2OyUKNEeW5mJpUa0D_fg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency25Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_wt2O0UKNEeW5mJpUa0D_fg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_wt2O2UKNEeW5mJpUa0D_fg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_wt2O4UKNEeW5mJpUa0D_fg")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; init; }
}
