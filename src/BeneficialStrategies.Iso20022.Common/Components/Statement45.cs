// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[IsoId("_Xt8p1zeQEeWm5uvLSn0jEw")]
[DisplayName("Statement")]
public record Statement45
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_YOYdYzeQEeWm5uvLSn0jEw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_YOYdazeQEeWm5uvLSn0jEw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_YOYdczeQEeWm5uvLSn0jEw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_YOYddTeQEeWm5uvLSn0jEw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_YOYdfTeQEeWm5uvLSn0jEw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency22Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_YOYdhTeQEeWm5uvLSn0jEw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_YOYdjTeQEeWm5uvLSn0jEw")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis7Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_YOYdlTeQEeWm5uvLSn0jEw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_YOYdnTeQEeWm5uvLSn0jEw")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }
}
