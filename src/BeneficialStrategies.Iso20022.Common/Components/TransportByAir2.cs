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
[IsoId("_Stxy7Np-Ed-ak6NoX_4Aeg_-388669200")]
[DisplayName("Transport By Air")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByAir2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportByAir2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportByAir2( AirportName1Choice_ reqDepartureAirport,AirportName1Choice_ reqDestinationAirport )
    {
        DepartureAirport = reqDepartureAirport;
        DestinationAirport = reqDestinationAirport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_St7j4Np-Ed-ak6NoX_4Aeg_1226966014")]
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
    [IsoId("_St7j4dp-Ed-ak6NoX_4Aeg_1212188159")]
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
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_St7j4tp-Ed-ak6NoX_4Aeg_164516905")]
    [DisplayName("Air Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AirCrrierNm")]
    #endif
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AirCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AirCarrierName { get; init; } 
    #else
    public System.String? AirCarrierName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
