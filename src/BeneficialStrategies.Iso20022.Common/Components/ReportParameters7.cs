// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Parameters7.
/// </summary>
[IsoId("_82z_cZIVEe-HRNGM304Vlw")]
[DisplayName("Report Parameters7")]
public record ReportParameters7
{
    /// <summary>
    /// Activity Indicator.
    /// </summary>
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Frequency.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required EventFrequency6Code Frequency { get; init; }

    /// <summary>
    /// Net Position Identification.
    /// </summary>
    [DisplayName("Net Position Identification")]
    [IsoXmlTag("NetPosId")]
    public required IsoMax35Text NetPositionIdentification { get; init; }

    /// <summary>
    /// Report Date And Time.
    /// </summary>
    [DisplayName("Report Date And Time")]
    [IsoXmlTag("RptDtAndTm")]
    public required DateAndDateTime2Choice_ ReportDateAndTime { get; init; }

    /// <summary>
    /// Report Number.
    /// </summary>
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public IsoExact5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Update Type.
    /// </summary>
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateType1Code UpdateType { get; init; }
}
