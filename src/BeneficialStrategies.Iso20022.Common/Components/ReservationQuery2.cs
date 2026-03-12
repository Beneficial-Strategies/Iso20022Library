// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the reservation query criteria.
/// </summary>
[IsoId("_kWL_IZlaEeeE1Ya-LgRsuQ")]
[DisplayName("Reservation Query")]
public partial record ReservationQuery2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_keMro5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; } 
    
    /// <summary>
    /// Defines the reservation query criteria.
    /// </summary>
    [IsoId("_keMrpZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Criteria")]
    [IsoXmlTag("RsvatnCrit")]
    public ReservationCriteria2Choice_? ReservationCriteria { get; init; } 
    
    
    #nullable disable
    
}
