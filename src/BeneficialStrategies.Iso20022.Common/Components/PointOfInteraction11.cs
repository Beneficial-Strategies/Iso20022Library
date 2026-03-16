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
[IsoId("_g0gcMS8SEeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction")]
public record PointOfInteraction11
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_g_yfIS8SEeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification177 Identification { get; init; }

    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_g_yfIy8SEeu125Ip9zFcsQ")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SystemName { get; init; }

    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_g_yfJS8SEeu125Ip9zFcsQ")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GroupIdentification { get; init; }

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_g_yfJy8SEeu125Ip9zFcsQ")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities9? Capabilities { get; init; }

    /// <summary>
    /// Time zone name as defined by IANA (Internet Assigned Numbers Authority) in the time zone data base. America/Chicago or Europe/Paris are examples of time zone names.
    /// </summary>
    [IsoId("_g_yfKS8SEeu125Ip9zFcsQ")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// </summary>
    [IsoId("_g_yfKy8SEeu125Ip9zFcsQ")]
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public LocationCategory3Code? TerminalIntegration { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_g_yfLS8SEeu125Ip9zFcsQ")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public PointOfInteractionComponent11? Component { get; init; }
}
