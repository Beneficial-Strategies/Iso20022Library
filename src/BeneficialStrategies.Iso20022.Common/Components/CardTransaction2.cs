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
[IsoId("_aq96ATj3EeSz-s1QOUJaOg")]
[DisplayName("Card Transaction")]
public record CardTransaction2
{
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_a65MYTj3EeSz-s1QOUJaOg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; }

    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_a65MYzj3EeSz-s1QOUJaOg")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; }

    /// <summary>
    /// Card transaction details, which can be either globalised by the acquirer or individual transaction.
    /// </summary>
    [IsoId("_a65MZTj3EeSz-s1QOUJaOg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public CardTransaction2Choice_? Transaction { get; init; }

    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_-P0IATj2EeSz-s1QOUJaOg")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount24? PrePaidAccount { get; init; }
}
