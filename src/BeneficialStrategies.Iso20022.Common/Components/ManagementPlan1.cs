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
[IsoId("_LYnu1H1DEeCF8NjrBemJWQ_327413113")]
[DisplayName("Management Plan")]
public record ManagementPlan1
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_LYnu1X1DEeCF8NjrBemJWQ_-1510703256")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification35? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_LYnu1n1DEeCF8NjrBemJWQ_2053974420")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification35 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_LYnu131DEeCF8NjrBemJWQ_-223303412")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet2> DataSet { get; init; } = [];
    // ID for the above is _LYnu131DEeCF8NjrBemJWQ_-223303412
}
