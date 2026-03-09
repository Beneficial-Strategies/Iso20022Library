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
[IsoId("_U78TmNp-Ed-ak6NoX_4Aeg_1136145440")]
[DisplayName("Transport By Air")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportByAir1
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
    [IsoId("_U78Tmdp-Ed-ak6NoX_4Aeg_885263197")]
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
    [IsoId("_U78Tmtp-Ed-ak6NoX_4Aeg_878799220")]
    [DisplayName("Destination Airport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAirprt")]
    #endif
    [IsoXmlTag("DstnAirprt")]
    public ValueList<AirportName1Choice_> DestinationAirport { get; init; } = new ValueList<AirportName1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _U78Tmtp-Ed-ak6NoX_4Aeg_878799220
    
    
    #nullable disable
    
}
