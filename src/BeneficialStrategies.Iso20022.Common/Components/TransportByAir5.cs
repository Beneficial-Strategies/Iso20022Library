// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by air.
/// </summary>
[IsoId("_Em4MoRriEeOVR9VN6fAMUg")]
[DisplayName("Transport By Air")]
public partial record TransportByAir5
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_E-k68RriEeOVR9VN6fAMUg")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public AirportName1Choice_? DepartureAirport { get; init; } 
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_E-k68xriEeOVR9VN6fAMUg")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public ValueList<AirportName1Choice_> DestinationAirport { get; init; } = [];
    // ID for the above is _E-k68xriEeOVR9VN6fAMUg
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_E-k69xriEeOVR9VN6fAMUg")]
    [DisplayName("Air Carrier Name")]
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AirCarrierName { get; init; } 
    
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_E-k6-RriEeOVR9VN6fAMUg")]
    [DisplayName("Air Carrier Country")]
    [IsoXmlTag("AirCrrierCtry")]
    public CountryCode? AirCarrierCountry { get; init; } 
    
    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_E-k6-xriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; } 
    
    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_E-k6_RriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; } 
    
    
    #nullable disable
    
}
