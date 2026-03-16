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
[IsoId("_Tr4EV5liEeeE1Ya-LgRsuQ")]
[DisplayName("Reservation Report")]
public record ReservationReport5
{
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [IsoId("_T0LEs5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required ReservationIdentification1 ReservationIdentification { get; init; }

    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_T0LEtZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Or Error")]
    [IsoXmlTag("RsvatnOrErr")]
    public required ReservationOrError7Choice_ ReservationOrError { get; init; }
}
