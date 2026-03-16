// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a defined period.
/// </summary>
[IsoId("_RORH9tp-Ed-ak6NoX_4Aeg_1205526240")]
[DisplayName("Statement")]
public record Statement8
{
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_RORH99p-Ed-ak6NoX_4Aeg_1205526258")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Period on which the statement is reporting.
    /// </summary>
    [IsoId("_RORH-Np-Ed-ak6NoX_4Aeg_1205526283")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required DatePeriodDetails StatementPeriod { get; init; }

    /// <summary>
    /// Creation date of the statement.
    /// </summary>
    [IsoId("_RORH-dp-Ed-ak6NoX_4Aeg_1206446349")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_RORH-tp-Ed-ak6NoX_4Aeg_1205526300")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public EventFrequency1Code? Frequency { get; init; }

    /// <summary>
    /// Specifies if the statement is complete or only contains changes.
    /// </summary>
    [IsoId("_RORH-9p-Ed-ak6NoX_4Aeg_1205526318")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateTypeCode UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_ROaR4Np-Ed-ak6NoX_4Aeg_1205526335")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_ROaR4dp-Ed-ak6NoX_4Aeg_1206446332")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }
}
