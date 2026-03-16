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
[IsoId("_Qp52ptp-Ed-ak6NoX_4Aeg_400350199")]
[DisplayName("Statement")]
public record Statement20
{
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_Qp52p9p-Ed-ak6NoX_4Aeg_-710561220")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    [IsoId("_Qp52qNp-Ed-ak6NoX_4Aeg_286511133")]
    [DisplayName("Query Reference")]
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryReference { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_Qp52qdp-Ed-ak6NoX_4Aeg_-1707633573")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_QqDnoNp-Ed-ak6NoX_4Aeg_1590261370")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_QqDnodp-Ed-ak6NoX_4Aeg_-1821956770")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency4Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QqDnotp-Ed-ak6NoX_4Aeg_-1935795836")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType2Choice_ UpdateType { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_QqDno9p-Ed-ak6NoX_4Aeg_1362099107")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasis3Choice_ StatementBasis { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QqDnpNp-Ed-ak6NoX_4Aeg_1475938173")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement is audited or not.
    /// </summary>
    [IsoId("_QqDnpdp-Ed-ak6NoX_4Aeg_478865820")]
    [DisplayName("Audited Indicator")]
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AuditedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    [IsoId("_QqDnptp-Ed-ak6NoX_4Aeg_-582425320")]
    [DisplayName("Sub Account Indicator")]
    [IsoXmlTag("SubAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubAccountIndicator { get; init; }

    /// <summary>
    /// Indicates whether the statement contains tax lot details.
    /// </summary>
    [IsoId("_QqDnp9p-Ed-ak6NoX_4Aeg_365026754")]
    [DisplayName("Tax Lot Indicator")]
    [IsoXmlTag("TaxLotInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TaxLotIndicator { get; init; }
}
