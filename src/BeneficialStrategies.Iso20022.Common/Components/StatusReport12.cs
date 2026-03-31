// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
[IsoId("_t7bCUXJjEe299ZbWCkdR_w")]
[DisplayName("Status Report")]
public record StatusReport12
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_uCvyUXJjEe299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    [IsoId("_uCvyU3JjEe299ZbWCkdR_w")]
    [DisplayName("Initiating Trigger")]
    [IsoXmlTag("InitgTrggr")]
    public TriggerInformation2? InitiatingTrigger { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_uCvyVXJjEe299ZbWCkdR_w")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_uCvyV3JjEe299ZbWCkdR_w")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required StatusReportDataSetRequest4 DataSet { get; init; }
}
