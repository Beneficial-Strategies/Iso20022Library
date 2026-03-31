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
[IsoId("_8bfoPZNLEeWGlc8L7oPDIg")]
[DisplayName("Statement")]
public record Statement56
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_8bfoQZNLEeWGlc8L7oPDIg")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_8bfoSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_8bfoUZNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; }

    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_8bfoU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required Period2Choice_ StatementPeriod { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_8bfoW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency26Choice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_8bfoY5NLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType16Choice_? UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_8bfoa5NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis12Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_8bfoc5NLEeWGlc8L7oPDIg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_8bfoe5NLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }
}
