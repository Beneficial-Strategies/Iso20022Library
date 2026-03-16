// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point of interaction (POI) performing the transaction.
/// </summary>
[IsoId("_-ioIkdkGEeiojJsa6FYyew")]
[DisplayName("Point Of Interaction")]
public record PointOfInteraction9
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_-sU3IdkGEeiojJsa6FYyew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification171 Identification { get; init; }

    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_-sU3I9kGEeiojJsa6FYyew")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; }

    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_-sU3JdkGEeiojJsa6FYyew")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; }

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_-sU3J9kGEeiojJsa6FYyew")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities8? Capabilities { get; init; }

    /// <summary>
    /// Time zone name as defined by IANA (Internet Assigned Numbers Authority) in the time zone data base. America/Chicago or Europe/Paris are examples of time zone names.
    /// </summary>
    [IsoId("_-sU3KdkGEeiojJsa6FYyew")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// </summary>
    [IsoId("_-sU3K9kGEeiojJsa6FYyew")]
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public LocationCategory3Code? TerminalIntegration { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_-sU3LdkGEeiojJsa6FYyew")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public PointOfInteractionComponent9? Component { get; init; }
}
