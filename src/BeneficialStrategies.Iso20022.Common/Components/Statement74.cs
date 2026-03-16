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
[IsoId("_coMp8dCAEeiO-eodGv5iKQ")]
[DisplayName("Statement")]
public record Statement74
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_c5nKE9CAEeiO-eodGv5iKQ")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_c5nKG9CAEeiO-eodGv5iKQ")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_c5nKI9CAEeiO-eodGv5iKQ")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_c5nKJdCAEeiO-eodGv5iKQ")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_c5nKLdCAEeiO-eodGv5iKQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency25Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_c5nKNdCAEeiO-eodGv5iKQ")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType15Choice_ UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_c5nKPdCAEeiO-eodGv5iKQ")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis7Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_c5nKRdCAEeiO-eodGv5iKQ")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement is audited or not.
    /// </summary>
    [IsoId("_c5nKTdCAEeiO-eodGv5iKQ")]
    [DisplayName("Audited Indicator")]
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AuditedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_c5nKVdCAEeiO-eodGv5iKQ")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement contains tax lot details.
    /// </summary>
    [IsoId("_c5nKXdCAEeiO-eodGv5iKQ")]
    [DisplayName("Tax Lot Indicator")]
    [IsoXmlTag("TaxLotInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TaxLotIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holdings on the account are subject to security interest, lien or right of set-off.
    /// </summary>
    [IsoId("_W1DKIdCBEeiO-eodGv5iKQ")]
    [DisplayName("Security Interest Or Set Off")]
    [IsoXmlTag("SctyIntrstOrSetOff")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityInterestOrSetOff { get; init; }
}
