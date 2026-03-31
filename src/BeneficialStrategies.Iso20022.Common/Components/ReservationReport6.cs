// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the reservation or on a business error.
/// </summary>
[IsoId("_DgmhZ24-EeiU9cctagi5ow")]
[DisplayName("Reservation Report")]
public record ReservationReport6
{
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [IsoId("_Dqby024-EeiU9cctagi5ow")]
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required ReservationIdentification2 ReservationIdentification { get; init; }

    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_Dqby1W4-EeiU9cctagi5ow")]
    [DisplayName("Reservation Or Error")]
    [IsoXmlTag("RsvatnOrErr")]
    public required ReservationOrError9Choice_ ReservationOrError { get; init; }
}
