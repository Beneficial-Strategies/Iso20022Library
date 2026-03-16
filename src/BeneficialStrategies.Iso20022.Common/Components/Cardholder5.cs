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
[IsoId("_47TdkS_uEeO4w-IWHJMI9g")]
[DisplayName("Cardholder")]
public record Cardholder5
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_5KB2ES_uEeO4w-IWHJMI9g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification7? Identification { get; init; }

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_5KB2Ey_uEeO4w-IWHJMI9g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// </summary>
    [IsoId("_5KB2FS_uEeO4w-IWHJMI9g")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }

    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_wPxEAEt9EeOC3MFxIpMwug")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress13? BillingAddress { get; init; }

    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_dHy7UEuCEeOC3MFxIpMwug")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress13? ShippingAddress { get; init; }

    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    [IsoId("_5KB2Fy_uEeO4w-IWHJMI9g")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderAuthentication5? Authentication { get; init; }

    /// <summary>
    /// Numeric characters of the cardholder&apos;s address for verification.
    /// </summary>
    [IsoId("_5KB2GS_uEeO4w-IWHJMI9g")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_5KB2Gy_uEeO4w-IWHJMI9g")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}
