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
[IsoId("_XkzG4cNTEeWGDrnsYu2p6g")]
[DisplayName("Consignment")]
public record Consignment4
{
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    [IsoId("_Xw_v0cNTEeWGDrnsYu2p6g")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public TradeParty3? Consignor { get; init; }

    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    [IsoId("_Xw_v08NTEeWGDrnsYu2p6g")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public TradeParty3? Consignee { get; init; }

    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    [IsoId("_Xw_v1cNTEeWGDrnsYu2p6g")]
    [DisplayName("Transport Means")]
    [IsoXmlTag("TrnsprtMeans")]
    public TransportMeans3? TransportMeans { get; init; }
}
