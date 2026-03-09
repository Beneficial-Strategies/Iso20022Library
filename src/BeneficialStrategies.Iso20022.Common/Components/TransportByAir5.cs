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
[IsoId("_Em4MoRriEeOVR9VN6fAMUg")]
[DisplayName("Transport By Air")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByAir5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_E-k68RriEeOVR9VN6fAMUg")]
    [DisplayName("Departure Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DprtureAirprt")]
    #endif
    [IsoXmlTag("DprtureAirprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AirportName1Choice_? DepartureAirport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AirportName1Choice_? DepartureAirport { get; init; } 
    #else
    public AirportName1Choice_? DepartureAirport { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_E-k68xriEeOVR9VN6fAMUg")]
    [DisplayName("Destination Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAirprt")]
    #endif
    [IsoXmlTag("DstnAirprt")]
    public ValueList<AirportName1Choice_> DestinationAirport { get; init; } = new ValueList<AirportName1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _E-k68xriEeOVR9VN6fAMUg
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_E-k69xriEeOVR9VN6fAMUg")]
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
    [IsoId("_E-k6-RriEeOVR9VN6fAMUg")]
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
    [IsoId("_E-k6-xriEeOVR9VN6fAMUg")]
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
    [IsoId("_E-k6_RriEeOVR9VN6fAMUg")]
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
