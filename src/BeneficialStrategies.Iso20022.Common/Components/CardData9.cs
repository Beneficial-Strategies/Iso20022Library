// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non-protected sensitive data associated with the card or payment token performing the transaction.
/// </summary>
[IsoId("_7N88cZF7EeukDPgU2BMkjQ")]
[DisplayName("Card Data")]
public record CardData9
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_7Ub-8ZF7EeukDPgU2BMkjQ")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PAN { get; init; }

    /// <summary>
    /// To indicate whether the PAN is using ProtectedData for encryption or not.
    /// False: The PAN is used in plain text
    /// True: The PAN is encrypted by using ProtectedData
    /// Default: False
    /// </summary>
    [IsoId("_7UcmAZF7EeukDPgU2BMkjQ")]
    [DisplayName("Protected PAN Indicator")]
    [IsoXmlTag("PrtctdPANInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_7UcmA5F7EeukDPgU2BMkjQ")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 &amp; ISO 8583:2003-1 bit 13
    /// </summary>
    [IsoId("_7UcmBZF7EeukDPgU2BMkjQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_7UcmB5F7EeukDPgU2BMkjQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? ExpiryDate { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 36
    /// </summary>
    [IsoId("_7UcmCZF7EeukDPgU2BMkjQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104, MinimumLength = 1)]
    public IsoMax104Text? Track3 { get; init; }

    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_7UcmC5F7EeukDPgU2BMkjQ")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio (for example, Issuer Identification Number). This data should not to be presented to the card acceptor or its environment. (for example, acquirer should not to send or make available to merchant).
    /// </summary>
    [IsoId("_7UcmDZF7EeukDPgU2BMkjQ")]
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PANAccountRange { get; init; }

    /// <summary>
    /// Last four digits of the PAN.
    /// </summary>
    [IsoId("_7UcmD5F7EeukDPgU2BMkjQ")]
    [DisplayName("PAN Four Last Digits")]
    [IsoXmlTag("PANFourLastDgts")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? PANFourLastDigits { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    [IsoId("_7UcmEZF7EeukDPgU2BMkjQ")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    public ISO3NumericCountryCode? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code assigned to the card by the card issuer.
    /// ISO 8583:2003 bit 6.
    /// </summary>
    [IsoId("_7UcmE5F7EeukDPgU2BMkjQ")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    public ISO3NumericCurrencyCode? CardCurrencyCode { get; init; }

    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_7UcmFZF7EeukDPgU2BMkjQ")]
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductType { get; init; }

    /// <summary>
    /// Subtype of card product.
    /// </summary>
    [IsoId("_7UcmF5F7EeukDPgU2BMkjQ")]
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductSubType { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_7UcmGZF7EeukDPgU2BMkjQ")]
    [DisplayName("Card Portfolio Identifier")]
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardPortfolioIdentifier { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_7UcmG5F7EeukDPgU2BMkjQ")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public ValueList<AdditionalData1> AdditionalCardData { get; init; } = [];
}
