// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Report information for one transaction.
/// </summary>
[IsoId("_z7EngU0yEeybj420QgWBkA")]
[DisplayName("Point Of Interaction Transaction Report")]
public record PointOfInteractionTransactionReport4
{
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    [IsoId("_0BjC8U0yEeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    [IsoId("_0BjC800yEeybj420QgWBkA")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse4? PaymentResponse { get; init; }
}
