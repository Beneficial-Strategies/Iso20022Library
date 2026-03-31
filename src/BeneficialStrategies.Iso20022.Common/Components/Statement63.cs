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
[IsoId("_AYkHkbPwEeelzbgsFa3sqQ")]
[DisplayName("Statement")]
public record Statement63
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_ApEow7PwEeelzbgsFa3sqQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_ApEoy7PwEeelzbgsFa3sqQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_ApEo07PwEeelzbgsFa3sqQ")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_ApEo1bPwEeelzbgsFa3sqQ")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ApEo3bPwEeelzbgsFa3sqQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_ApEo5bPwEeelzbgsFa3sqQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ApEo7bPwEeelzbgsFa3sqQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
