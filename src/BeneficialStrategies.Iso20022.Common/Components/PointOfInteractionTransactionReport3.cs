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
[IsoId("_p3uQgS8PEeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction Transaction Report")]
public record PointOfInteractionTransactionReport3
{
    /// <summary>
    /// Response for this specific transaction.
    /// </summary>
    [IsoId("_qC9QIS8PEeu125Ip9zFcsQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Data responded to a Payment request.
    /// </summary>
    [IsoId("_qC9QIy8PEeu125Ip9zFcsQ")]
    [DisplayName("Payment Response")]
    [IsoXmlTag("PmtRspn")]
    public PaymentResponse3? PaymentResponse { get; init; }
}
