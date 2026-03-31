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
[IsoId("_we-icaH8EeuiuNcvKhXmNQ")]
[DisplayName("Terminal")]
public record Terminal5
{
    /// <summary>
    /// Identification of the terminal performing the transaction.
    /// </summary>
    [IsoId("_wkbDIaH8EeuiuNcvKhXmNQ")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    public TerminalIdentification3? TerminalIdentification { get; init; }

    /// <summary>
    /// Type of terminal.
    /// </summary>
    [IsoId("_Y9u9AcWbEeuhguwJmlgagQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TerminalType1Code? Type { get; init; }

    /// <summary>
    /// Other type of terminal.
    /// </summary>
    [IsoId("_a25eEcWbEeuhguwJmlgagQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Capabilities of the terminal.
    /// </summary>
    [IsoId("_wkbqMaH8EeuiuNcvKhXmNQ")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public Capabilities2? Capabilities { get; init; }

    /// <summary>
    /// Type of terminal integration at a point of service location.
    /// </summary>
    [IsoId("_wkbqNaH8EeuiuNcvKhXmNQ")]
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public TerminalIntegrationCategory1Code? TerminalIntegration { get; init; }

    /// <summary>
    /// Geographic location of the terminal.
    /// </summary>
    [IsoId("_FC3UkcWcEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Indicates whether the terminal is operated outdoor or indoor at the point of service.
    /// True: The terminal is operated outdoor.
    /// False: The terminal is operated indoor.
    /// </summary>
    [IsoId("_wkbqN6H8EeuiuNcvKhXmNQ")]
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
    [IsoId("_wkbqOaH8EeuiuNcvKhXmNQ")]
    [DisplayName("Off Premises Indicator")]
    [IsoXmlTag("OffPrmissInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OffPremisesIndicator { get; init; }

    /// <summary>
    /// Indicates whether the transaction was performed on board.
    /// True: The terminal is located on board.
    /// False: The terminal is not located on board.
    /// </summary>
    [IsoId("_wkbqO6H8EeuiuNcvKhXmNQ")]
    [DisplayName("On Board Indicator")]
    [IsoXmlTag("OnBrdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnBoardIndicator { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the transactions.
    /// </summary>
    [IsoId("_wkbqPaH8EeuiuNcvKhXmNQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent13> POIComponent { get; init; } = [];
}
