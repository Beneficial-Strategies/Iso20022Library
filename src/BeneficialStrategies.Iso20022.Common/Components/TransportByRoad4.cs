// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by road.
/// </summary>
[IsoId("_Nh2S0dQxEeK0PPbKncCqzA")]
[DisplayName("Transport By Road")]
public record TransportByRoad4
{
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_N9DoIdQxEeK0PPbKncCqzA")]
    [DisplayName("Place Of Receipt")]
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfReceipt { get; init; }

    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_N9DoI9QxEeK0PPbKncCqzA")]
    [DisplayName("Place Of Delivery")]
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PlaceOfDelivery { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_N9DoJdQxEeK0PPbKncCqzA")]
    [DisplayName("Road Carrier Name")]
    [IsoXmlTag("RoadCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? RoadCarrierName { get; init; }

    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_1Xt0gBUzEeOCqpkCrPgk4g")]
    [DisplayName("Road Carrier Country")]
    [IsoXmlTag("RoadCrrierCtry")]
    public CountryCode? RoadCarrierCountry { get; init; }

    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_6f1k4BUzEeOCqpkCrPgk4g")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; }

    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_3vLE8BriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; }
}
