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
[IsoId("_-K7fQQxtEeqdx6buGpCCQw")]
[DisplayName("Cardholder")]
public record Cardholder16
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_-WE_UQxtEeqdx6buGpCCQw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification15? Identification { get; init; }

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_-WE_UwxtEeqdx6buGpCCQw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_-WE_VQxtEeqdx6buGpCCQw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_-WE_VwxtEeqdx6buGpCCQw")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress22? BillingAddress { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_-WE_WQxtEeqdx6buGpCCQw")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress22? ShippingAddress { get; init; }

    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [IsoId("_-WE_WwxtEeqdx6buGpCCQw")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TripNumber { get; init; }

    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [IsoId("_-WE_XQxtEeqdx6buGpCCQw")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle1? Vehicle { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_-WE_XwxtEeqdx6buGpCCQw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication13> Authentication { get; init; } = [];

    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_-WE_YQxtEeqdx6buGpCCQw")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_-WE_YwxtEeqdx6buGpCCQw")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }

    /// <summary>
    /// Data related to the mobile of stakeholder.
    /// </summary>
    [IsoId("_-WE_ZQxtEeqdx6buGpCCQw")]
    [DisplayName("Mobile Data")]
    [IsoXmlTag("MobData")]
    public ValueList<MobileData2> MobileData { get; init; } = [];
}
