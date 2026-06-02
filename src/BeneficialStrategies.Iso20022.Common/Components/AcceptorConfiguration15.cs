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
[IsoId("_0AyA4bZzEfCUZfsQO4rYeA")]
[DisplayName("Acceptor Configuration15")]
public record AcceptorConfiguration15
{
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_0Br_1bZzEfCUZfsQO4rYeA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_0Br_27ZzEfCUZfsQO4rYeA")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    public SimpleValueList<IsoMax35Text> POIGroupIdentification { get; init; } = [];

    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_0Br_4bZzEfCUZfsQO4rYeA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    [MinLength(1)]
    public ValueList<AcceptorConfigurationDataSet7> DataSet { get; init; } = [];
}
