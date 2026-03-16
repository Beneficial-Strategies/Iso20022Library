// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI, its components and their installed versions.
/// </summary>
[IsoId("_LYnu2H1DEeCF8NjrBemJWQ_885541956")]
[DisplayName("Status Report")]
public record StatusReport1
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_LYxf0H1DEeCF8NjrBemJWQ_-329044493")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification35 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_LYxf0X1DEeCF8NjrBemJWQ_962719669")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification35? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_LYxf0n1DEeCF8NjrBemJWQ_1866758529")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet1> DataSet { get; init; } = [];
    // ID for the above is _LYxf0n1DEeCF8NjrBemJWQ_1866758529
}
