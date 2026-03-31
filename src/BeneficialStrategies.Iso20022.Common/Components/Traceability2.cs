// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
/// </summary>
[IsoId("_D8G5oWegEeSh-d9-KfCEyA")]
[DisplayName("Traceability")]
public record Traceability2
{
    /// <summary>
    /// Identification of a partner of a message exchange.
    /// </summary>
    [IsoId("_EKHgcWegEeSh-d9-KfCEyA")]
    [DisplayName("Relay Identification")]
    [IsoXmlTag("RlayId")]
    public required GenericIdentification76 RelayIdentification { get; init; }

    /// <summary>
    /// Date and time of incoming data exchange for relaying or processing.
    /// </summary>
    [IsoId("_EKHgc2egEeSh-d9-KfCEyA")]
    [DisplayName("Trace Date Time In")]
    [IsoXmlTag("TracDtTmIn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeIn { get; init; }

    /// <summary>
    /// Date and time of the outgoing exchange for relaying or processing.
    /// </summary>
    [IsoId("_EKHgdWegEeSh-d9-KfCEyA")]
    [DisplayName("Trace Date Time Out")]
    [IsoXmlTag("TracDtTmOut")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TraceDateTimeOut { get; init; }
}
