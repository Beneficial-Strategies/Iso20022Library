// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reservation Query6.
/// </summary>
[IsoId("_zqcjkTEyEe6g-ffJsqGiSA")]
[DisplayName("Reservation Query6")]
public record ReservationQuery6
{
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryType2Code? QueryType { get; init; }

    /// <summary>
    /// Reservation Criteria.
    /// </summary>
    [DisplayName("Reservation Criteria")]
    [IsoXmlTag("RsvatnCrit")]
    public ReservationCriteria6Choice_? ReservationCriteria { get; init; }
}
