// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_U2H_d9p-Ed-ak6NoX_4Aeg_1774400712")]
[DisplayName("Statement")]
public record Statement4
{
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_U2H_eNp-Ed-ak6NoX_4Aeg_-890624474")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_U2RwcNp-Ed-ak6NoX_4Aeg_-890624036")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Preparation date of the statement.
    /// </summary>
    [IsoId("_U2Rwcdp-Ed-ak6NoX_4Aeg_-890623933")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_U2Rwctp-Ed-ak6NoX_4Aeg_-890623621")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public FrequencyCodeAndDSSCodeChoice_? Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_U2Rwc9p-Ed-ak6NoX_4Aeg_-861073393")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public StatementUpdateTypeCodeAndDSSCodeChoice_? UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_U2RwdNp-Ed-ak6NoX_4Aeg_-861073290")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_U2Rwddp-Ed-ak6NoX_4Aeg_1042036197")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public StatementBasisCodeAndDSSCodeChoice_? StatementBasis { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_U2Rwdtp-Ed-ak6NoX_4Aeg_-861072377")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Indicates whether the statement is audited.
    /// </summary>
    [IsoId("_U2Rwd9p-Ed-ak6NoX_4Aeg_1862134746")]
    [DisplayName("Audited Indicator")]
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AuditedIndicator { get; init; }
}
