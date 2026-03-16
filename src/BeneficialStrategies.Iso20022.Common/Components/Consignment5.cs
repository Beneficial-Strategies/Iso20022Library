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
[IsoId("_XzXXgeWoEeevU7McUP3D1w")]
[DisplayName("Consignment")]
public record Consignment5
{
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    [IsoId("_X8NKceWoEeevU7McUP3D1w")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public TradeParty4? Consignor { get; init; }

    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    [IsoId("_X8NKc-WoEeevU7McUP3D1w")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public TradeParty4? Consignee { get; init; }

    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    [IsoId("_X8NKdeWoEeevU7McUP3D1w")]
    [DisplayName("Transport Means")]
    [IsoXmlTag("TrnsprtMeans")]
    public TransportMeans3? TransportMeans { get; init; }
}
