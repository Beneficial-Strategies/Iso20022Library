// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_qoBw4QvVEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment10
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_qzVpAQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer2? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_qzVpBQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_qzVpCQvVEeKzJ69IWwzB9Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction2 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_qzVpDQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard6 Card { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_qzVpEQvVEeKzJ69IWwzB9Q")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder4? Cardholder { get; init; }
}
