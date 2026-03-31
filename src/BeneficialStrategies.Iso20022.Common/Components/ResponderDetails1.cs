// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the Financial Institution responding to the request.
/// </summary>
[IsoId("_SuwKHAEcEeCQm6a_G2yO_w_2135472976")]
[DisplayName("Responder Details")]
public record ResponderDetails1
{
    /// <summary>
    /// Date and time at which the response was created.
    /// </summary>
    [IsoId("_SuwKHQEcEeCQm6a_G2yO_w_-495861824")]
    [DisplayName("Date Time Stamp")]
    [IsoXmlTag("DtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTimeStamp { get; init; }

    /// <summary>
    /// Identification of the responder.
    /// </summary>
    [IsoId("_Su5UAAEcEeCQm6a_G2yO_w_569448861")]
    [DisplayName("Responder")]
    [IsoXmlTag("Rspndr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Responder { get; init; }
}
