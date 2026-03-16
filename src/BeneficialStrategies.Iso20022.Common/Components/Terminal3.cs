// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment terminal or ATM performing the transaction
/// </summary>
[IsoId("_e4IxaewNEeiMkKo2clXHdQ")]
[DisplayName("Terminal")]
public record Terminal3
{
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e4IxcewNEeiMkKo2clXHdQ")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public TerminalIdentification2? TerminalIdentification { get; init; }

    /// <summary>
    /// Capabilities of the terminal.
    /// </summary>
    [IsoId("_e4Ixa-wNEeiMkKo2clXHdQ")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public Capabilities1? Capabilities { get; init; }

    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    [IsoId("_e4Ixb-wNEeiMkKo2clXHdQ")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; }

    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    [IsoId("_e4IxbuwNEeiMkKo2clXHdQ")]
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; }

    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor.
    /// False: The terminal is operated indoor.
    /// </summary>
    [IsoId("_e4IxbOwNEeiMkKo2clXHdQ")]
    [DisplayName("Outdoor Indicator")]
    [IsoXmlTag("OutdrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OutdoorIndicator { get; init; }

    /// <summary>
    /// Indicates whether the terminal is operated on- or off-premises at the point of service.
    /// True: The terminal is operated off premises.
    /// False: The terminal is operated on premises.
    /// ISO 8583:93 bit 22-4, ISO 8583:2003 bit 22-3.
    /// </summary>
    [IsoId("_e4IxbewNEeiMkKo2clXHdQ")]
    [DisplayName("Off Premises Indicator")]
    [IsoXmlTag("OffPrmissInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OffPremisesIndicator { get; init; }

    /// <summary>
    /// Indicates whether the transaction was performed on board.
    /// True: The terminal is located on board.
    /// False: The terminal is not located on board.
    /// </summary>
    [IsoId("_e4IxcOwNEeiMkKo2clXHdQ")]
    [DisplayName("On Board Indicator")]
    [IsoXmlTag("OnBrdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnBoardIndicator { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    [IsoId("_e4IxauwNEeiMkKo2clXHdQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent8? POIComponent { get; init; }
}
