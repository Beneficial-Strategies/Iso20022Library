// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reservation Report8.
/// </summary>
[IsoId("_61-9NTEyEe6g-ffJsqGiSA")]
[DisplayName("Reservation Report8")]
public record ReservationReport8
{
    /// <summary>
    /// Reservation Identification.
    /// </summary>
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required ReservationIdentification4 ReservationIdentification { get; init; }

    /// <summary>
    /// Reservation Or Error.
    /// </summary>
    [DisplayName("Reservation Or Error")]
    [IsoXmlTag("RsvatnOrErr")]
    public required ReservationOrError9Choice_ ReservationOrError { get; init; }
}
