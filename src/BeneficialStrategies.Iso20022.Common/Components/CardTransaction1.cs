// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction details.
/// </summary>
[IsoId("_t6sBoFkyEeGeoaLUQk__nA_1677846126")]
[DisplayName("Card Transaction")]
public record CardTransaction1
{
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_t6sBoVkyEeGeoaLUQk__nA_-254821706")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; }

    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_t61LkFkyEeGeoaLUQk__nA_1493186018")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; }

    /// <summary>
    /// Card transaction details, which can be either globalised by the acquirer or individual transaction.
    /// </summary>
    [IsoId("_t61LkVkyEeGeoaLUQk__nA_1329787492")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardTransaction1Choice_? Transaction { get; init; }
}
