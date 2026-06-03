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
[IsoId("_QXleYbZ0EfCUZfsQO4rYeA")]
[DisplayName("Point Of Interaction16")]
public record PointOfInteraction16
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_QcAEVbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification177 Identification { get; init; }

    /// <summary>
    /// Common name assigned by the acquirer to the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_QcAEW7Z0EfCUZfsQO4rYeA")]
    [DisplayName("System Name")]
    [IsoXmlTag("SysNm")]
    public IsoMax70Text? SystemName { get; init; }

    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI (Point Of Interaction) terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_QcAEYbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    public IsoMax35Text? GroupIdentification { get; init; }

    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_QcAEZ7Z0EfCUZfsQO4rYeA")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities11? Capabilities { get; init; }

    /// <summary>
    /// Time zone name as defined by IANA in the time zone data base.
    /// </summary>
    [IsoId("_QcAEbbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    public IsoMax70Text? TimeZone { get; init; }

    /// <summary>
    /// Indicates the type of integration of the POI terminal in the sale environment.
    /// </summary>
    [IsoId("_QcAEc7Z0EfCUZfsQO4rYeA")]
    [DisplayName("Terminal Integration")]
    [IsoXmlTag("TermnlIntgtn")]
    public LocationCategory3Code? TerminalIntegration { get; init; }

    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_QcAEebZ0EfCUZfsQO4rYeA")]
    [DisplayName("Component")]
    [IsoXmlTag("Cmpnt")]
    public ValueList<PointOfInteractionComponent18> Component { get; init; } = [];
}
