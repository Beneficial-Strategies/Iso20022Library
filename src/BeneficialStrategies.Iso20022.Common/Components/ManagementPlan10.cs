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
[IsoId("_H559EU6qEeyGi9JAv6wq7Q")]
[DisplayName("Management Plan")]
public record ManagementPlan10
{
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    [IsoId("_IAhicU6qEeyGi9JAv6wq7Q")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification176? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_IAhic06qEeyGi9JAv6wq7Q")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_IAhidU6qEeyGi9JAv6wq7Q")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required TerminalManagementDataSet31 DataSet { get; init; }
}
