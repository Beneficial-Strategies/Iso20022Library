// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement86.
/// </summary>
[IsoId("_o6uPAZIWEe-HRNGM304Vlw")]
[DisplayName("Statement86")]
public record Statement86
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
    /// Report Number.
    /// </summary>
    [DisplayName("Report Number")]
    [IsoXmlTag("RptNb")]
    public IsoExact5NumericText? ReportNumber { get; init; }

    /// <summary>
    /// Statement Date And Time.
    /// </summary>
    [DisplayName("Statement Date And Time")]
    [IsoXmlTag("StmtDtAndTm")]
    public required DateAndDateTime2Choice_ StatementDateAndTime { get; init; }

    /// <summary>
    /// Statement Identification.
    /// </summary>
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Update Type.
    /// </summary>
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required StatementUpdateType1Code UpdateType { get; init; }
}
