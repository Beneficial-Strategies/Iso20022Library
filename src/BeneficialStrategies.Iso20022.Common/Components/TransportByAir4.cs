// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by air.
/// </summary>
[IsoId("_yXPisdQwEeK0PPbKncCqzA")]
[DisplayName("Transport By Air")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByAir4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportByAir4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportByAir4( AirportName1Choice_ reqDepartureAirport,AirportName1Choice_ reqDestinationAirport )
    {
        DepartureAirport = reqDepartureAirport;
        DestinationAirport = reqDestinationAirport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_y08LUdQwEeK0PPbKncCqzA")]
    [DisplayName("Departure Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DprtureAirprt")]
    #endif
    [IsoXmlTag("DprtureAirprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AirportName1Choice_ DepartureAirport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AirportName1Choice_ DepartureAirport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AirportName1Choice_ DepartureAirport { get; init; } 
    #else
    public AirportName1Choice_ DepartureAirport { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_y08LU9QwEeK0PPbKncCqzA")]
    [DisplayName("Destination Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAirprt")]
    #endif
    [IsoXmlTag("DstnAirprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AirportName1Choice_ DestinationAirport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AirportName1Choice_ DestinationAirport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AirportName1Choice_ DestinationAirport { get; init; } 
    #else
    public AirportName1Choice_ DestinationAirport { get; set; } 
    #endif
    
    /// <summary>
    /// Flight number allocated by the airline that is carrying the goods from an airport of departure to an airport of destination;.
    /// </summary>
    [IsoId("_-uNGENQ1EeK0PPbKncCqzA")]
    [DisplayName("Flight Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlghtNb")]
    #endif
    [IsoXmlTag("FlghtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FlightNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FlightNumber { get; init; } 
    #else
    public System.String? FlightNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_y08LVdQwEeK0PPbKncCqzA")]
    [DisplayName("Air Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AirCrrierNm")]
    #endif
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AirCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AirCarrierName { get; init; } 
    #else
    public System.String? AirCarrierName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_EWTXANQ2EeK0PPbKncCqzA")]
    [DisplayName("Air Carrier Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AirCrrierCtry")]
    #endif
    [IsoXmlTag("AirCrrierCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? AirCarrierCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AirCarrierCountry { get; init; } 
    #else
    public string? AirCarrierCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_JJ8sMNQ2EeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtNm")]
    #endif
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CarrierAgentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CarrierAgentName { get; init; } 
    #else
    public System.String? CarrierAgentName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_L7-H4NQ2EeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtCtry")]
    #endif
    [IsoXmlTag("CrrierAgtCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CarrierAgentCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CarrierAgentCountry { get; init; } 
    #else
    public string? CarrierAgentCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
