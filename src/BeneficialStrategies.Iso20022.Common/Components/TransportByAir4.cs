// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by air.
/// </summary>
[IsoId("_yXPisdQwEeK0PPbKncCqzA")]
[DisplayName("Transport By Air")]
public record TransportByAir4
{
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_y08LUdQwEeK0PPbKncCqzA")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public required AirportName1Choice_ DepartureAirport { get; init; }

    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_y08LU9QwEeK0PPbKncCqzA")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public required AirportName1Choice_ DestinationAirport { get; init; }

    /// <summary>
    /// Flight number allocated by the airline that is carrying the goods from an airport of departure to an airport of destination;.
    /// </summary>
    [IsoId("_-uNGENQ1EeK0PPbKncCqzA")]
    [DisplayName("Flight Number")]
    [IsoXmlTag("FlghtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FlightNumber { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_y08LVdQwEeK0PPbKncCqzA")]
    [DisplayName("Air Carrier Name")]
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AirCarrierName { get; init; }

    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_EWTXANQ2EeK0PPbKncCqzA")]
    [DisplayName("Air Carrier Country")]
    [IsoXmlTag("AirCrrierCtry")]
    public CountryCode? AirCarrierCountry { get; init; }

    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_JJ8sMNQ2EeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; }

    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_L7-H4NQ2EeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; }
}
