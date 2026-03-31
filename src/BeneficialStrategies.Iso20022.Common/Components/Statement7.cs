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
[IsoId("_ROaR4tp-Ed-ak6NoX_4Aeg_2093891418")]
[DisplayName("Statement")]
public record Statement7
{
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_ROaR49p-Ed-ak6NoX_4Aeg_2093891420")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_ROaR5Np-Ed-ak6NoX_4Aeg_2093891678")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Preparation date of the statement.
    /// </summary>
    [IsoId("_ROaR5dp-Ed-ak6NoX_4Aeg_2093891695")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ROaR5tp-Ed-ak6NoX_4Aeg_2093891713")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_ROaR59p-Ed-ak6NoX_4Aeg_2093891730")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ROaR6Np-Ed-ak6NoX_4Aeg_2093891748")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_ROkC4Np-Ed-ak6NoX_4Aeg_2093891773")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_ROkC4dp-Ed-ak6NoX_4Aeg_2094811762")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }
}
