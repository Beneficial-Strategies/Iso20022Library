// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies what to do during a card reader initialisation.
/// </summary>
[IsoId("_JUhW8XGfEe2TbaNWBpRZpQ")]
[DisplayName("Device Initialisation Card Reader Request")]
public partial record DeviceInitialisationCardReaderRequest5
{
    #nullable enable
    
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_JaxI4XGfEe2TbaNWBpRZpQ")]
    [DisplayName("Warm Reset Flag")]
    [IsoXmlTag("WarmRstFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 
    
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_JaxI43GfEe2TbaNWBpRZpQ")]
    [DisplayName("Force Entry Mode")]
    [IsoXmlTag("ForceNtryMd")]
    public CardDataReading8Code? ForceEntryMode { get; init; } 
    
    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("_JaxI5XGfEe2TbaNWBpRZpQ")]
    [DisplayName("Leave Card Flag")]
    [IsoXmlTag("LeavCardFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 
    
    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_JaxI53GfEe2TbaNWBpRZpQ")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_JaxI6XGfEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage10? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
