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
[IsoId("_LIl04QvdEeK9Xewg3qiFQA")]
[DisplayName("Acceptor Configuration")]
public record AcceptorConfiguration2
{
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_LZ2kAQvdEeK9Xewg3qiFQA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification35? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_LZ2kBQvdEeK9Xewg3qiFQA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification35 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_LZ2kCQvdEeK9Xewg3qiFQA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet6> DataSet { get; init; } = [];
    // ID for the above is _LZ2kCQvdEeK9Xewg3qiFQA
}
