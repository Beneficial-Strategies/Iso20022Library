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
[IsoId("_QrGJdtp-Ed-ak6NoX_4Aeg_1434348299")]
[DisplayName("Statement")]
public record Statement19
{
    /// <summary>
    /// Identification assigned by the portfolio transfer counterpart to unambiguously identify a portfolio transfer notification.
    /// </summary>
    [IsoId("_QrGJd9p-Ed-ak6NoX_4Aeg_-1628529124")]
    [DisplayName("Counterparty Portfolio Transfer Notification Reference")]
    [IsoXmlTag("CtrPtyPrtflTrfNtfctnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CounterpartyPortfolioTransferNotificationReference { get; init; }

    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    [IsoId("_QrGJeNp-Ed-ak6NoX_4Aeg_1516539741")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public Number3Choice_? ReportNumber { get; init; }

    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    [IsoId("_QrGJedp-Ed-ak6NoX_4Aeg_1516539758")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatementIdentification { get; init; }

    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    [IsoId("_QrGJetp-Ed-ak6NoX_4Aeg_2113885950")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_QrGJe9p-Ed-ak6NoX_4Aeg_1516539836")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public UpdateType2Choice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_QrP6cNp-Ed-ak6NoX_4Aeg_1516539853")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }
}
