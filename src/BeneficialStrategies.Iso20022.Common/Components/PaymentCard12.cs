// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
[IsoId("_46pQwXr6EeSZrs_hiwNOWA")]
[DisplayName("Payment Card")]
public record PaymentCard12
{
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_5HA40Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_5HA403r6EeSZrs_hiwNOWA")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData10? PlainCardData { get; init; }

    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_5HA41Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? IssuerBIN { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_5HA413r6EeSZrs_hiwNOWA")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_5HA42Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_5HA433r6EeSZrs_hiwNOWA")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; }
}
