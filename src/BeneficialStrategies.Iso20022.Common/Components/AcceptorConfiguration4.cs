// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor configuration to be downloaded from the terminal management system.
/// </summary>
[IsoId("_oHe8gWpaEeS4r8z7dKyh1g")]
[DisplayName("Acceptor Configuration")]
public record AcceptorConfiguration4
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_oV8PQWpaEeS4r8z7dKyh1g")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification71? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_oV8PQ2paEeS4r8z7dKyh1g")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification71 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_oV8PRWpaEeS4r8z7dKyh1g")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet14> DataSet { get; init; } = [];
    // ID for the above is _oV8PRWpaEeS4r8z7dKyh1g
}
