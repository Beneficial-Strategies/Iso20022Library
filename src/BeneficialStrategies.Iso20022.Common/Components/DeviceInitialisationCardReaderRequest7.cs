// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies what to do during a card reader initialisation.
/// </summary>
[IsoId("_PwJQcbZfEfCUZfsQO4rYeA")]
[DisplayName("Device Initialisation Card Reader Request7")]
public record DeviceInitialisationCardReaderRequest7
{
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    [IsoId("_PxHg1bZfEfCUZfsQO4rYeA")]
    [DisplayName("Warm Reset Flag")]
    [IsoXmlTag("WarmRstFlg")]
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; }

    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    [IsoId("_PxHg27ZfEfCUZfsQO4rYeA")]
    [DisplayName("Force Entry Mode")]
    [IsoXmlTag("ForceNtryMd")]
    public SimpleValueList<CardDataReading8Code> ForceEntryMode { get; init; } = [];

    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    [IsoId("_PxHg4bZfEfCUZfsQO4rYeA")]
    [DisplayName("Leave Card Flag")]
    [IsoXmlTag("LeavCardFlg")]
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; }

    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    [IsoId("_PxHg57ZfEfCUZfsQO4rYeA")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    public IsoNumber? MaximumWaitingTime { get; init; }

    /// <summary>
    /// Information to display.
    /// </summary>
    [IsoId("_PxHg7bZfEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }
}
