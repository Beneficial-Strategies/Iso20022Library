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
[IsoId("_QxgTctp-Ed-ak6NoX_4Aeg_-1743572610")]
[DisplayName("Statement")]
public record Statement12
{
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_QxgTc9p-Ed-ak6NoX_4Aeg_-1695550125")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType1Code StatementType { get; init; }

    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_QxgTdNp-Ed-ak6NoX_4Aeg_1236770237")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; }

    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_QxgTddp-Ed-ak6NoX_4Aeg_-1743572330")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_QxgTdtp-Ed-ak6NoX_4Aeg_-1743571815")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_QxgTd9p-Ed-ak6NoX_4Aeg_-1743572240")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QxgTeNp-Ed-ak6NoX_4Aeg_-1743572209")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency4Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_QxqEcNp-Ed-ak6NoX_4Aeg_-1743572148")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType2Choice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QxqEcdp-Ed-ak6NoX_4Aeg_-1743572117")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_QxqEctp-Ed-ak6NoX_4Aeg_940178444")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriodChoice_? NotificationDeadlinePeriod { get; init; }
}
