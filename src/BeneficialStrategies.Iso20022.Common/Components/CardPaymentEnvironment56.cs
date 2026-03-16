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
[IsoId("_JA5r4Y3aEeW56qaqQ8B0kQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment56
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_JMOyIY3aEeW56qaqQ8B0kQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Merchant involved in the card payment transaction.
    /// </summary>
    [IsoId("_JMOyI43aEeW56qaqQ8B0kQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_JMOyJY3aEeW56qaqQ8B0kQ")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction5 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_JMOyJ43aEeW56qaqQ8B0kQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard21 Card { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference: ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_JMOyKY3aEeW56qaqQ8B0kQ")]
    [DisplayName("Cardholder Language")]
    [IsoXmlTag("CrdhldrLang")]
    public LanguageCode? CardholderLanguage { get; init; }
}
