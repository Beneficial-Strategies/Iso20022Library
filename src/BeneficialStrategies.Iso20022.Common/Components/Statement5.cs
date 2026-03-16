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
[IsoId("_U2bhcNp-Ed-ak6NoX_4Aeg_-1152328071")]
[DisplayName("Statement")]
public record Statement5
{
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_U2bhcdp-Ed-ak6NoX_4Aeg_-745053391")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Period on which the statement is reporting.
    /// </summary>
    [IsoId("_U2bhctp-Ed-ak6NoX_4Aeg_-744130782")]
    [DisplayName("Statement Period")]
    [IsoXmlTag("StmtPrd")]
    public required DatePeriodDetails StatementPeriod { get; init; }

    /// <summary>
    /// Creation date of the statement.
    /// </summary>
    [IsoId("_U2bhc9p-Ed-ak6NoX_4Aeg_-1738700253")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_U2bhdNp-Ed-ak6NoX_4Aeg_-744130396")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency1Code? Frequency { get; init; }

    /// <summary>
    /// Specifies if the statement is complete or only contains changes.
    /// </summary>
    [IsoId("_U2bhddp-Ed-ak6NoX_4Aeg_-744130266")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateTypeCode UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    [IsoId("_U2bhdtp-Ed-ak6NoX_4Aeg_-744129929")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_U2bhd9p-Ed-ak6NoX_4Aeg_-1269226021")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }
}
