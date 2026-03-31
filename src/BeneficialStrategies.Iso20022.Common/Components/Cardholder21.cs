// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cardholder21.
/// </summary>
[IsoId("_0VCDsZFQEe6reqfAp4CunQ")]
[DisplayName("Cardholder21")]
public record Cardholder21
{
    /// <summary>
    /// Authentication.
    /// </summary>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication17> Authentication { get; init; } = [];

    /// <summary>
    /// Billing Address.
    /// </summary>
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress22? BillingAddress { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification15? Identification { get; init; }

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Mobile Data.
    /// </summary>
    [DisplayName("Mobile Data")]
    [IsoXmlTag("MobData")]
    public ValueList<MobileData6> MobileData { get; init; } = [];

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Personal Data.
    /// </summary>
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    public IsoMax70Text? PersonalData { get; init; }

    /// <summary>
    /// Shipping Address.
    /// </summary>
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress22? ShippingAddress { get; init; }

    /// <summary>
    /// Transaction Verification Result.
    /// </summary>
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public ValueList<TransactionVerificationResult4> TransactionVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Trip Number.
    /// </summary>
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    public IsoMax35Text? TripNumber { get; init; }

    /// <summary>
    /// Vehicle.
    /// </summary>
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle1? Vehicle { get; init; }
}
