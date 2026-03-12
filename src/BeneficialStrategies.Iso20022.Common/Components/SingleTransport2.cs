// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies individually each leg of a transport of goods.
/// </summary>
[IsoId("_U7fnpNp-Ed-ak6NoX_4Aeg_-2082710326")]
[DisplayName("Single Transport")]
public partial record SingleTransport2
{
    #nullable enable
    
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    [IsoId("_U7fnpdp-Ed-ak6NoX_4Aeg_-1668050769")]
    [DisplayName("Transport By Air")]
    [IsoXmlTag("TrnsprtByAir")]
    public TransportByAir2? TransportByAir { get; init; } 
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_U7fnptp-Ed-ak6NoX_4Aeg_-1679131651")]
    [DisplayName("Transport By Sea")]
    [IsoXmlTag("TrnsprtBySea")]
    public TransportBySea2? TransportBySea { get; init; } 
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_U7fnp9p-Ed-ak6NoX_4Aeg_-1683750967")]
    [DisplayName("Transport By Road")]
    [IsoXmlTag("TrnsprtByRoad")]
    public TransportByRoad2? TransportByRoad { get; init; } 
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_U7oxkNp-Ed-ak6NoX_4Aeg_-1621872359")]
    [DisplayName("Transport By Rail")]
    [IsoXmlTag("TrnsprtByRail")]
    public TransportByRail2? TransportByRail { get; init; } 
    
    
    #nullable disable
    
}
