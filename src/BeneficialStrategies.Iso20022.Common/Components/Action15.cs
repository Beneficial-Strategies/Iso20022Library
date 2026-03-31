// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action15.
/// </summary>
[IsoId("_FotEkZFJEe6reqfAp4CunQ")]
[DisplayName("Action15")]
public record Action15
{
    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType13Code ActionType { get; init; }

    /// <summary>
    /// Message To Present.
    /// </summary>
    [DisplayName("Message To Present")]
    [IsoXmlTag("MsgToPres")]
    public ActionMessage11? MessageToPresent { get; init; }

    /// <summary>
    /// Remote Access.
    /// </summary>
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters7? RemoteAccess { get; init; }

    /// <summary>
    /// Retry.
    /// </summary>
    [DisplayName("Retry")]
    [IsoXmlTag("Rtry")]
    public ProcessRetry3? Retry { get; init; }

    /// <summary>
    /// Time Condition.
    /// </summary>
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming6? TimeCondition { get; init; }
}
