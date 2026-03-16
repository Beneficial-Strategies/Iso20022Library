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
[IsoId("_ROkC4tp-Ed-ak6NoX_4Aeg_634334074")]
[DisplayName("Statement")]
public record Statement6
{
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_ROkC49p-Ed-ak6NoX_4Aeg_634334076")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_ROkC5Np-Ed-ak6NoX_4Aeg_634334091")]
    [DisplayName("Statement Date Time")]
    [IsoXmlTag("StmtDtTm")]
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; }

    /// <summary>
    /// Preparation date of the statement.
    /// </summary>
    [IsoId("_ROkC5dp-Ed-ak6NoX_4Aeg_634334109")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_ROkC5tp-Ed-ak6NoX_4Aeg_634334134")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; }

    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_ROkC59p-Ed-ak6NoX_4Aeg_634334151")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_ROtz4Np-Ed-ak6NoX_4Aeg_634334169")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_ROtz4dp-Ed-ak6NoX_4Aeg_634334194")]
    [DisplayName("Statement Basis")]
    [IsoXmlTag("StmtBsis")]
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; }

    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_ROtz4tp-Ed-ak6NoX_4Aeg_634334211")]
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Indicates whether the statement is audited.
    /// </summary>
    [IsoId("_ROtz49p-Ed-ak6NoX_4Aeg_634334229")]
    [DisplayName("Audited Indicator")]
    [IsoXmlTag("AudtdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AuditedIndicator { get; init; }
}
