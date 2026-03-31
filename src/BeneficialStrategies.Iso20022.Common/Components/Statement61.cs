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
[IsoId("_XEt3Qa3NEeey8N0JWnVPUw")]
[DisplayName("Statement")]
public record Statement61
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_XPY2M63NEeey8N0JWnVPUw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_XPY2O63NEeey8N0JWnVPUw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_XPY2Q63NEeey8N0JWnVPUw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_XPY2Ra3NEeey8N0JWnVPUw")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required Period5Choice_ StatementPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_XPY2Ta3NEeey8N0JWnVPUw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency25Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_XPY2Va3NEeey8N0JWnVPUw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType15Choice_? UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_XPY2Xa3NEeey8N0JWnVPUw")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis8Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_XPY2Za3NEeey8N0JWnVPUw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_XPY2ba3NEeey8N0JWnVPUw")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }
}
