// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the reservation query criteria.
/// </summary>
[IsoId("_xW4kEQy_Ee2Wmf2RrXviyA")]
[DisplayName("Reservation Query")]
public record ReservationQuery5
{
    /// <summary>
    /// Specifies the type of matching items to be returned in the response to the query.
    /// </summary>
    [IsoId("_xghoQQy_Ee2Wmf2RrXviyA")]
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Defines the reservation query criteria.
    /// </summary>
    [IsoId("_xghoQwy_Ee2Wmf2RrXviyA")]
    [DisplayName("Reservation Criteria")]
    [IsoXmlTag("RsvatnCrit")]
    public ReservationCriteria5Choice_? ReservationCriteria { get; init; }
}
