// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action17.
/// </summary>
[IsoId("_nw7Z4Z9SEe-nbM0aSPcoiQ")]
[DisplayName("Action17")]
public partial record Action17
{
    #nullable enable

    /// <summary>
    /// Action Type.
    /// </summary>
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required ActionType15Code ActionType { get; init; } 

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

    
    #nullable disable
    
}
