// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Device Initialisation Card Reader Request message.
/// </summary>
[IsoId("_DHlm0N7AEeiwsev40qZGEQ")]
[DisplayName("Device Initialisation Card Reader Request")]
public partial record DeviceInitialisationCardReaderRequest1
{
    #nullable enable
    
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_4NZUsN7AEeiwsev40qZGEQ")]
    [DisplayName("Warm Reset Flag")]
    [IsoXmlTag("WarmRstFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_L1MasN7BEeiwsev40qZGEQ")]
    [DisplayName("Force Entry Mode")]
    [IsoXmlTag("ForceNtryMd")]
    public CardDataReading6Code? ForceEntryMode { get; init; } 
    
    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("__jq-sN7AEeiwsev40qZGEQ")]
    [DisplayName("Leave Card Flag")]
    [IsoXmlTag("LeavCardFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 
    
    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_IA5psN7BEeiwsev40qZGEQ")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_eqBysN7BEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage6? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
