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
[IsoId("_T4VBgXh1EeidzqjNEfehPg")]
[DisplayName("Card Transaction")]
public record CardTransaction17
{
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_UG5pAXh1EeidzqjNEfehPg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; }

    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_UG5pA3h1EeidzqjNEfehPg")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; }

    /// <summary>
    /// Card transaction details, which can be either globalised by the acquirer or individual transaction.
    /// </summary>
    [IsoId("_UG5pBXh1EeidzqjNEfehPg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardTransaction3Choice_? Transaction { get; init; }

    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_UG5pB3h1EeidzqjNEfehPg")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount38? PrePaidAccount { get; init; }
}
