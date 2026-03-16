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
[IsoId("_6N_O8YIAEeS7UOLM47txvA")]
[DisplayName("Cardholder")]
public record Cardholder9
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_6azi8YIAEeS7UOLM47txvA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification7? Identification { get; init; }

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_6azi84IAEeS7UOLM47txvA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_6azi9YIAEeS7UOLM47txvA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_6azi94IAEeS7UOLM47txvA")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress18? BillingAddress { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_6azi-YIAEeS7UOLM47txvA")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress18? ShippingAddress { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_6azi-4IAEeS7UOLM47txvA")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderAuthentication7? Authentication { get; init; }

    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_6azi_YIAEeS7UOLM47txvA")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_6azi_4IAEeS7UOLM47txvA")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}
