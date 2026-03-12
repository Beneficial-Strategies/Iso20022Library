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
[IsoId("_U78TmNp-Ed-ak6NoX_4Aeg_1136145440")]
[DisplayName("Transport By Air")]
public partial record TransportByAir1
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    [IsoId("_U78Tmdp-Ed-ak6NoX_4Aeg_885263197")]
    [DisplayName("Departure Airport")]
    [IsoXmlTag("DprtureAirprt")]
    public AirportName1Choice_? DepartureAirport { get; init; } 
    
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    [IsoId("_U78Tmtp-Ed-ak6NoX_4Aeg_878799220")]
    [DisplayName("Destination Airport")]
    [IsoXmlTag("DstnAirprt")]
    public ValueList<AirportName1Choice_> DestinationAirport { get; init; } = new ValueList<AirportName1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _U78Tmtp-Ed-ak6NoX_4Aeg_878799220
    
    
    #nullable disable
    
}
