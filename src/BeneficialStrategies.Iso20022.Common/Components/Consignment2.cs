// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the arrangement of the transport of goods and services and the parties involved in this process.
/// </summary>
[IsoId("_S-10hgEcEeCQm6a_G2yO_w_-323080810")]
[DisplayName("Consignment")]
public record Consignment2
{
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    [IsoId("_S-10hwEcEeCQm6a_G2yO_w_379767677")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public TradeParty1? Consignor { get; init; }

    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    [IsoId("_S-10iAEcEeCQm6a_G2yO_w_-20999364")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public TradeParty1? Consignee { get; init; }

    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    [IsoId("_S-_lgAEcEeCQm6a_G2yO_w_-1584428859")]
    [DisplayName("Transport Means")]
    [IsoXmlTag("TrnsprtMeans")]
    public TransportMeans3? TransportMeans { get; init; }
}
