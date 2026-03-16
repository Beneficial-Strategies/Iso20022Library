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
[IsoId("_5TFs1ZNLEeWGlc8L7oPDIg")]
[DisplayName("Statement")]
public record Statement50
{
    /// <summary>
    /// Identification assigned by the portfolio transfer counterpart to unambiguously identify a portfolio transfer notification.
    /// </summary>
    [IsoId("_5TFs15NLEeWGlc8L7oPDIg")]
    [DisplayName("Counterparty Portfolio Transfer Notification Reference")]
    [IsoXmlTag("CtrPtyPrtflTrfNtfctnRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CounterpartyPortfolioTransferNotificationReference { get; init; }

    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_5TFs2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_5TFs4ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_5TFs45NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_5TFs65NLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType16Choice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_5TFs85NLEeWGlc8L7oPDIg")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
