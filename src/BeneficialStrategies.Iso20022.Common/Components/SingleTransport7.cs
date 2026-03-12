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
[IsoId("_aFxzoRrhEeOVR9VN6fAMUg")]
[DisplayName("Single Transport")]
public partial record SingleTransport7
{
    #nullable enable
    
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_adK_8RrhEeOVR9VN6fAMUg")]
    [DisplayName("Transport By Air")]
    [IsoXmlTag("TrnsprtByAir")]
    public TransportByAir5? TransportByAir { get; init; } 
    
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    [IsoId("_adK_8xrhEeOVR9VN6fAMUg")]
    [DisplayName("Transport By Sea")]
    [IsoXmlTag("TrnsprtBySea")]
    public TransportBySea6? TransportBySea { get; init; } 
    
    /// <summary>
    /// Information related to the transportation of goods by road.
    /// </summary>
    [IsoId("_adK_9RrhEeOVR9VN6fAMUg")]
    [DisplayName("Transport By Road")]
    [IsoXmlTag("TrnsprtByRoad")]
    public TransportByRoad5? TransportByRoad { get; init; } 
    
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    [IsoId("_adK_9xrhEeOVR9VN6fAMUg")]
    [DisplayName("Transport By Rail")]
    [IsoXmlTag("TrnsprtByRail")]
    public TransportByRail5? TransportByRail { get; init; } 
    
    
    #nullable disable
    
}
