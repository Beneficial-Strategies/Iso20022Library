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
[IsoId("_uLWKY_fVEeiNZp_PtLohLw")]
[DisplayName("Statement")]
public record Statement77
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_uLWKZ_fVEeiNZp_PtLohLw")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_uLWKb_fVEeiNZp_PtLohLw")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_uLWKd_fVEeiNZp_PtLohLw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_uLWKeffVEeiNZp_PtLohLw")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_uLWKgffVEeiNZp_PtLohLw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency34Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_uLWKiffVEeiNZp_PtLohLw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType16Choice_ UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_uLWKkffVEeiNZp_PtLohLw")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis9Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_uLWKmffVEeiNZp_PtLohLw")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_uLWKoffVEeiNZp_PtLohLw")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holdings on the account are subject to security interest, lien or right of set-off.
    /// </summary>
    [IsoId("_uLWKqffVEeiNZp_PtLohLw")]
    [DisplayName("Security Interest Or Set Off")]
    [IsoXmlTag("SctyIntrstOrSetOff")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityInterestOrSetOff { get; init; }
}
