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
[IsoId("_StCfm66BEeexrtTFgmVD3Q")]
[DisplayName("Card Transaction")]
public record CardTransaction16
{
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_S1q3Ia6BEeexrtTFgmVD3Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; }

    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_S1q3I66BEeexrtTFgmVD3Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; }

    /// <summary>
    /// Card transaction details, which can be either globalised by the acquirer or individual transaction.
    /// </summary>
    [IsoId("_S1q3Ja6BEeexrtTFgmVD3Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardTransaction3Choice_? Transaction { get; init; }

    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_S1q3J66BEeexrtTFgmVD3Q")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount24? PrePaidAccount { get; init; }
}
