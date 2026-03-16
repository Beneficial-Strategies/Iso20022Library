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
[IsoId("_3Ts24WjMEeSHBr6v3XO0Mg")]
[DisplayName("Cardholder")]
public record Cardholder7
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_3hbJ0WjMEeSHBr6v3XO0Mg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification7? Identification { get; init; }

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_3hbJ02jMEeSHBr6v3XO0Mg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_3hbJ1WjMEeSHBr6v3XO0Mg")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_3hbJ12jMEeSHBr6v3XO0Mg")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress13? BillingAddress { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_3hbJ2WjMEeSHBr6v3XO0Mg")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress13? ShippingAddress { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder.
    /// </summary>
    [IsoId("_3hbJ22jMEeSHBr6v3XO0Mg")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication6> Authentication { get; init; } = [];

    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_63ojwGjkEeSDR-pyia6Xtg")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult3> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_3hbJ32jMEeSHBr6v3XO0Mg")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}
