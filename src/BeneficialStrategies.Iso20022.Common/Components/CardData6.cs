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
[IsoId("_RcdeYIEHEeu6D49Gi-ZPwQ")]
[DisplayName("Card Data")]
public record CardData6
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_RicxoYEHEeu6D49Gi-ZPwQ")]
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
    [IsoId("_RidYsYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Protected PAN Indicator")]
    [IsoXmlTag("PrtctdPANInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_RidYs4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used, expressed in one of the following formats: YYYY-MM-DD, YYYY-MM, YY-MM-DD.
    /// ISO 8583:93 &amp; ISO 8583:2003-1 bit 13
    /// </summary>
    [IsoId("_RidYtYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_RidYt4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? ExpiryDate { get; init; }

    /// <summary>
    /// Service attached to the card as defined in ISO 7813.
    /// ISO 8583 bit 40.
    /// </summary>
    [IsoId("_RidYuYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 45
    /// </summary>
    [IsoId("_RidYu4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76, MinimumLength = 1)]
    public IsoMax76Text? Track1 { get; init; }

    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format  conforms to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 35
    /// </summary>
    [IsoId("_RidYvYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck2")]
    public Track2Data1Choice_? Track2 { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content conforms to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// ISO 8583 bit 36
    /// </summary>
    [IsoId("_RidYv4EHEeu6D49Gi-ZPwQ")]
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
    [IsoId("_RidYwYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio (for example, Issuer Identification Number). This data should not to be presented to the card acceptor or its environment. (for example, acquirer should not to send or make available to merchant).
    /// </summary>
    [IsoId("_CYCp4TEEEeyjbpgZW6G1Fg")]
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PANAccountRange { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// ISO 8583 bit 20
    /// </summary>
    [IsoId("_RidYw4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    public ISO3NumericCountryCode? CardCountryCode { get; init; }

    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_RidYxYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductType { get; init; }

    /// <summary>
    /// Subtype of card product.
    /// </summary>
    [IsoId("_RidYx4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductSubType { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_RidYyYEHEeu6D49Gi-ZPwQ")]
    [DisplayName("Card Portfolio Identifier")]
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardPortfolioIdentifier { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_RidYy4EHEeu6D49Gi-ZPwQ")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public AdditionalData1? AdditionalCardData { get; init; }
}
