// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
[IsoId("_OXgF0ds7Eee9e6xduATmQg")]
[DisplayName("Cardholder")]
public record Cardholder13
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_OgaKMds7Eee9e6xduATmQg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification15? Identification { get; init; }

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_OgaKM9s7Eee9e6xduATmQg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_OgaKNds7Eee9e6xduATmQg")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_OgaKN9s7Eee9e6xduATmQg")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress22? BillingAddress { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_OgaKOds7Eee9e6xduATmQg")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress22? ShippingAddress { get; init; }

    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [IsoId("_OgaKO9s7Eee9e6xduATmQg")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripNumber { get; init; }

    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [IsoId("_OgaKPds7Eee9e6xduATmQg")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle1? Vehicle { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_OgaKP9s7Eee9e6xduATmQg")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderAuthentication11? Authentication { get; init; }

    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_OgaKQds7Eee9e6xduATmQg")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_OgaKQ9s7Eee9e6xduATmQg")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}
