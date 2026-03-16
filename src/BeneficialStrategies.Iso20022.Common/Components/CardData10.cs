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
[IsoId("_rYiS0SFNEey8XKHwKquEQw")]
[DisplayName("Card Data")]
public record CardData10
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_re1IESFNEey8XKHwKquEQw")]
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
    [IsoId("_re1IEyFNEey8XKHwKquEQw")]
    [DisplayName("Protected PAN Indicator")]
    [IsoXmlTag("PrtctdPANInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ProtectedPANIndicator { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_re1IFSFNEey8XKHwKquEQw")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// A unique non-financial reference assigned to a given payment account. May be used to link all transaction activity associated with the same payment account.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_re1IFyFNEey8XKHwKquEQw")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Leading digits of the PAN that identifies the card portfolio (for example, Issuer Identification Number). This data should not to be presented to the card acceptor or its environment. (for example, acquirer should not to send or make available to merchant).
    /// </summary>
    [IsoId("_re1IGSFNEey8XKHwKquEQw")]
    [DisplayName("PAN Account Range")]
    [IsoXmlTag("PANAcctRg")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PANAccountRange { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_re1IGyFNEey8XKHwKquEQw")]
    [DisplayName("Card Portfolio Identifier")]
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardPortfolioIdentifier { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_re1IHSFNEey8XKHwKquEQw")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public AdditionalData1? AdditionalCardData { get; init; }
}
