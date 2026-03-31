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
[IsoId("_yceqIWpJEeSR-ZWLvO-1dg")]
[DisplayName("Status Report")]
public record StatusReport4
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_ypADMWpJEeSR-ZWLvO-1dg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification71 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_ypADM2pJEeSR-ZWLvO-1dg")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification71? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_ypADNWpJEeSR-ZWLvO-1dg")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public required TerminalManagementDataSet13 DataSet { get; init; }
}
