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
[IsoId("_2hD-EWpCEeS4VPLpYyQgxQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment44
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_2tbmIWpCEeS4VPLpYyQgxQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Merchant involved in the card payment transaction.
    /// </summary>
    [IsoId("_2tbmI2pCEeS4VPLpYyQgxQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_2tbmJWpCEeS4VPLpYyQgxQ")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction4 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_2tbmJ2pCEeS4VPLpYyQgxQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard9 Card { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference: ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_2tbmKWpCEeS4VPLpYyQgxQ")]
    [DisplayName("Cardholder Language")]
    [IsoXmlTag("CrdhldrLang")]
    public LanguageCode? CardholderLanguage { get; init; }
}
