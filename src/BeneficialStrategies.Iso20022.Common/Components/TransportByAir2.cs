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
[IsoId("_Stxy7Np-Ed-ak6NoX_4Aeg_-388669200")]
[DisplayName("Transport By Air")]
public partial record TransportByAir2
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_St7j4Np-Ed-ak6NoX_4Aeg_1226966014")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public required AirportName1Choice_ DepartureAirport { get; init; } 
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_St7j4dp-Ed-ak6NoX_4Aeg_1212188159")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public required AirportName1Choice_ DestinationAirport { get; init; } 
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_St7j4tp-Ed-ak6NoX_4Aeg_164516905")]
    [DisplayName("Air Carrier Name")]
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AirCarrierName { get; init; } 
    
    
    #nullable disable
    
}
