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
[IsoId("_77QEcVaJEeeFltjJxERUxw")]
[DisplayName("Card Data")]
public record CardData2
{
    /// <summary>
    /// Primary Account Number (PAN) of the card or a surrogate of the PAN such as a payment token.
    /// ISO 8583 bit 2
    /// </summary>
    [IsoId("_8HdUcVaJEeeFltjJxERUxw")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PAN { get; init; }

    /// <summary>
    /// Distinguishes between instances of the same payment card.
    /// ISO 8583 bit 23
    /// </summary>
    [IsoId("_8HdUc1aJEeeFltjJxERUxw")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Unique non-financial reference assigned to a given PAN. May be used to link the transaction activity to that PAN.
    /// ISO 8583:87 bit 56 (TLV tag 01/dataset 71)
    /// ISO 8583:93 bit 112 (TLV tag 01/dataset 71)
    /// ISO 8583:2003 bit 51 (TLV tag 01/dataset 71)
    /// </summary>
    [IsoId("_zClc8fGpEeiGNursv3uE_g")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Identifies the card portfolio.
    /// </summary>
    [IsoId("_SjR2gZaQEemfCcEf5rVTyg")]
    [DisplayName("Card Portfolio Identifier")]
    [IsoXmlTag("CardPrtflIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardPortfolioIdentifier { get; init; }
}
