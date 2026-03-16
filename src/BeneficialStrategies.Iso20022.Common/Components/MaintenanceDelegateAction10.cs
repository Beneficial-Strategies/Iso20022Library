// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance Delegate Action10.
/// </summary>
[IsoId("_QoOzsaE5Ee-MRKYsaX6JDg")]
[DisplayName("Maintenance Delegate Action10")]
public record MaintenanceDelegateAction10
{
    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction13> Action { get; init; } = [];

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Data Set Identification.
    /// </summary>
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification11? DataSetIdentification { get; init; }

    /// <summary>
    /// Periodic Action.
    /// </summary>
    [DisplayName("Periodic Action")]
    [IsoXmlTag("PrdcActn")]
    public IsoTrueFalseIndicator? PeriodicAction { get; init; }

    /// <summary>
    /// Re Try.
    /// </summary>
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; }

    /// <summary>
    /// TM Remote Access.
    /// </summary>
    [DisplayName("TM Remote Access")]
    [IsoXmlTag("TMRmotAccs")]
    public NetworkParameters7? TMRemoteAccess { get; init; }

    /// <summary>
    /// TMS Protocol.
    /// </summary>
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// TMS Protocol Version.
    /// </summary>
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    public IsoMax35Text? TMSProtocolVersion { get; init; }
}
