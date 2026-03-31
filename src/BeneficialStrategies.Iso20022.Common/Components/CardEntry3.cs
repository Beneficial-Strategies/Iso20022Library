// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card transaction entry.
/// </summary>
[IsoId("_SbnYYa6BEeexrtTFgmVD3Q")]
[DisplayName("Card Entry")]
public record CardEntry3
{
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_SkavEa6BEeexrtTFgmVD3Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard4? Card { get; init; }

    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_SkavE66BEeexrtTFgmVD3Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; }

    /// <summary>
    /// Card entry details, based on card transaction aggregated data performed by the account servicer.
    /// </summary>
    [IsoId("_SkavFa6BEeexrtTFgmVD3Q")]
    [DisplayName("Aggregated Entry")]
    [IsoXmlTag("AggtdNtry")]
    public CardAggregated2? AggregatedEntry { get; init; }

    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_SkavF66BEeexrtTFgmVD3Q")]
    [DisplayName("Pre Paid Account")]
    [IsoXmlTag("PrePdAcct")]
    public CashAccount24? PrePaidAccount { get; init; }
}
