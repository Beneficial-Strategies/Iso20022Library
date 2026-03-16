// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the cancellation.
/// </summary>
[IsoId("_TEWmpAEcEeCQm6a_G2yO_w_698590174")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment4
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TEWmpQEcEeCQm6a_G2yO_w_1201826353")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer1? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment cancellation.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TEWmpgEcEeCQm6a_G2yO_w_1916743141")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation5? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TEWmpwEcEeCQm6a_G2yO_w_-1932639859")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction1 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TEWmqAEcEeCQm6a_G2yO_w_-854239574")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard3 Card { get; init; }
}
