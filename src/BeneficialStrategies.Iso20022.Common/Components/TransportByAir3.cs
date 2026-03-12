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
[IsoId("_St7j49p-Ed-ak6NoX_4Aeg_1854659956")]
[DisplayName("Transport By Air")]
public partial record TransportByAir3
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_St7j5Np-Ed-ak6NoX_4Aeg_1854660080")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public AirportName1Choice_? DepartureAirport { get; init; } 
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_St7j5dp-Ed-ak6NoX_4Aeg_1854660141")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public ValueList<AirportName1Choice_> DestinationAirport { get; init; } = new ValueList<AirportName1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _St7j5dp-Ed-ak6NoX_4Aeg_1854660141
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_St7j5tp-Ed-ak6NoX_4Aeg_1854659987")]
    [DisplayName("Air Carrier Name")]
    [IsoXmlTag("AirCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AirCarrierName { get; init; } 
    
    
    #nullable disable
    
}
