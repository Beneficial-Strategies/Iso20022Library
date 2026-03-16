// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the POI (Point Of Interaction) system.
/// </summary>
[IsoId("_jdDcsXG4Ee2TbaNWBpRZpQ")]
[DisplayName("Action")]
public record Action14
{
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_jjQLUXG4Ee2TbaNWBpRZpQ")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType13Code ActionType { get; init; }

    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_jjQLU3G4Ee2TbaNWBpRZpQ")]
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage10? MessageToPresent { get; init; }

    /// <summary>
    /// Access information to reach the target host.
    /// </summary>
    [IsoId("_fNvHIHG5Ee2TbaNWBpRZpQ")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters7? RemoteAccess { get; init; }

    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_FdK2oHG6Ee2TbaNWBpRZpQ")]
    [DisplayName("Retry")]
    [IsoXmlTag("Rtry")]
    public ProcessRetry3? Retry { get; init; }

    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_o_CMoHG6Ee2TbaNWBpRZpQ")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming6? TimeCondition { get; init; }
}
