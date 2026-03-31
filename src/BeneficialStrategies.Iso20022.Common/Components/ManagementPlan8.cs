// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
[IsoId("_TVsscQ01EeqUVL7sB4m7NA")]
[DisplayName("Management Plan")]
public record ManagementPlan8
{
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    [IsoId("_TjsFIQ01EeqUVL7sB4m7NA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification176? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_TjsFIw01EeqUVL7sB4m7NA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_TjsFJQ01EeqUVL7sB4m7NA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required TerminalManagementDataSet29 DataSet { get; init; }
}
