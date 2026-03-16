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
[IsoId("_PLZ6oXJ3Ee299ZbWCkdR_w")]
[DisplayName("Acceptor Configuration")]
public record AcceptorConfiguration12
{
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_PRyPcXJ3Ee299ZbWCkdR_w")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_PRyPc3J3Ee299ZbWCkdR_w")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; }

    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_PRyPdXJ3Ee299ZbWCkdR_w")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<AcceptorConfigurationDataSet4> DataSet { get; init; } = [];
    // ID for the above is _PRyPdXJ3Ee299ZbWCkdR_w
}
