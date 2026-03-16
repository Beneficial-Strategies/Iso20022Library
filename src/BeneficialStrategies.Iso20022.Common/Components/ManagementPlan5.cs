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
[IsoId("_N1xKQY30EeWYyJ6P6VfQMg")]
[DisplayName("Management Plan")]
public record ManagementPlan5
{
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    [IsoId("_OB13YY30EeWYyJ6P6VfQMg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification71? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_OB13Y430EeWYyJ6P6VfQMg")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification71 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_OB13ZY30EeWYyJ6P6VfQMg")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required TerminalManagementDataSet18 DataSet { get; init; }
}
