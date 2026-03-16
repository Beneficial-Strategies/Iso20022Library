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
[IsoId("_qrED1c3iEee5nJBZsW8MFQ")]
[DisplayName("Statement")]
public record Statement66
{
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    [IsoId("_qrED183iEee5nJBZsW8MFQ")]
    [DisplayName("Statement Type")]
    [IsoXmlTag("StmtTp")]
    public required CorporateActionStatementType1Code StatementType { get; init; }

    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    [IsoId("_qrED2c3iEee5nJBZsW8MFQ")]
    [DisplayName("Reporting Type")]
    [IsoXmlTag("RptgTp")]
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; }

    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_qrED283iEee5nJBZsW8MFQ")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text StatementIdentification { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_qrED3c3iEee5nJBZsW8MFQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_qrED5c3iEee5nJBZsW8MFQ")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_qrED7c3iEee5nJBZsW8MFQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency26Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_qrED9c3iEee5nJBZsW8MFQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType16Choice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_qrED_c3iEee5nJBZsW8MFQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    [IsoId("_qrEEBc3iEee5nJBZsW8MFQ")]
    [DisplayName("Notification Deadline Period")]
    [IsoXmlTag("NtfctnDdlnPrd")]
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; init; }
}
