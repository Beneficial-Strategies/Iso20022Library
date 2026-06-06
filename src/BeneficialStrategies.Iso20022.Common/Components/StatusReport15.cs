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
[IsoId("_r0Z0wbYEEfCUZfsQO4rYeA")]
[DisplayName("Status Report15")]
public record StatusReport15
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_r1TMpbYEEfCUZfsQO4rYeA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    [IsoId("_r1TMq7YEEfCUZfsQO4rYeA")]
    [DisplayName("Initiating Trigger")]
    [IsoXmlTag("InitgTrggr")]
    public TriggerInformation2? InitiatingTrigger { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_r1TMsbYEEfCUZfsQO4rYeA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_r1TMt7YEEfCUZfsQO4rYeA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required StatusReportDataSetRequest7 DataSet { get; init; }
}
