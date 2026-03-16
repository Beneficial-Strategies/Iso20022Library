// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Initialisation Card Reader Request6.
/// </summary>
[IsoId("_rGJyAZCPEe6zroekBXoFoQ")]
[DisplayName("Device Initialisation Card Reader Request6")]
public partial record DeviceInitialisationCardReaderRequest6
{
    #nullable enable

    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; } 

    /// <summary>
    /// Force Entry Mode.
    /// </summary>
    [DisplayName("Force Entry Mode")]
    [IsoXmlTag("ForceNtryMd")]
    public ValueList<CardDataReading8Code> ForceEntryMode { get; init; } = [];

    /// <summary>
    /// Leave Card Flag.
    /// </summary>
    [DisplayName("Leave Card Flag")]
    [IsoXmlTag("LeavCardFlg")]
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 

    /// <summary>
    /// Maximum Waiting Time.
    /// </summary>
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    public IsoNumber? MaximumWaitingTime { get; init; } 

    /// <summary>
    /// Warm Reset Flag.
    /// </summary>
    [DisplayName("Warm Reset Flag")]
    [IsoXmlTag("WarmRstFlg")]
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 

    
    #nullable disable
    
}
