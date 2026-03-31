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
[IsoId("_WugWsa3NEeey8N0JWnVPUw")]
[DisplayName("Statement")]
public record Statement60
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_W6LbM63NEeey8N0JWnVPUw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_W6LbO63NEeey8N0JWnVPUw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_W6LbQ63NEeey8N0JWnVPUw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_W6LbRa3NEeey8N0JWnVPUw")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required Period5Choice_ StatementPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_W6MCQ63NEeey8N0JWnVPUw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_W6MCS63NEeey8N0JWnVPUw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_W6MCU63NEeey8N0JWnVPUw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
