// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card performing the withdrawal transaction.
/// </summary>
[IsoId("_mtfUUa4KEeWZgJQOa6iKCQ")]
[DisplayName("Payment Card")]
public record PaymentCard23
{
    /// <summary>
    /// Entry mode that used to obtain the card data.
    /// </summary>
    [IsoId("_m6ToUa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading1Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Indicate the occurrence of a fall-back on the card entry mode.
    /// </summary>
    [IsoId("_m6ToU64KEeWZgJQOa6iKCQ")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public CardFallback1Code? FallbackIndicator { get; init; }

    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_m6ToVa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_m6ToV64KEeWZgJQOa6iKCQ")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData19? PlainCardData { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_m6ToWa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_m6ToW64KEeWZgJQOa6iKCQ")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Balance of the captured card or epurse if available.
    /// </summary>
    [IsoId("_m6ToXa4KEeWZgJQOa6iKCQ")]
    [DisplayName("Electronic Purse Balance")]
    [IsoXmlTag("ElctrncPrsBal")]
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; }
}
