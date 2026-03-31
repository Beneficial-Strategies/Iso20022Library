// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Device Initialisation Card Reader Request message.
/// </summary>
[IsoId("_eLA2kVE6EeyApZmLzm74zA")]
[DisplayName("Device Initialisation Card Reader Request")]
public record DeviceInitialisationCardReaderRequest4
{
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_eRG3gVE6EeyApZmLzm74zA")]
    [DisplayName("Warm Reset Flag")]
    [IsoXmlTag("WarmRstFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; }

    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_eRG3g1E6EeyApZmLzm74zA")]
    [DisplayName("Force Entry Mode")]
    [IsoXmlTag("ForceNtryMd")]
    public SimpleValueList<CardDataReading8Code> ForceEntryMode { get; init; } = [];

    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("_eRG3hVE6EeyApZmLzm74zA")]
    [DisplayName("Leave Card Flag")]
    [IsoXmlTag("LeavCardFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; }

    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_eRG3h1E6EeyApZmLzm74zA")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; }

    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_eRG3iVE6EeyApZmLzm74zA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage9? DisplayOutput { get; init; }
}
