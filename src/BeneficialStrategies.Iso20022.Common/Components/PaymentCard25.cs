// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
/// </summary>
[IsoId("_xQcjuTbsEead9bDRE_1DAQ")]
[DisplayName("Payment Card")]
public record PaymentCard25
{
    /// <summary>
    /// Type of card, for example, credit card.
    /// </summary>
    [IsoId("_xp4-YTbsEead9bDRE_1DAQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardType1Code Type { get; init; }

    /// <summary>
    /// Number embossed on a card that links the card to the account owner and account servicer.
    /// </summary>
    [IsoId("_xp4-YzbsEead9bDRE_1DAQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }

    /// <summary>
    /// Party entitled by a card issuer to use a card.
    /// </summary>
    [IsoId("_xp4-ZTbsEead9bDRE_1DAQ")]
    [DisplayName("Holder Name")]
    [IsoXmlTag("HldrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HolderName { get; init; }

    /// <summary>
    /// Year and month the card is available for use.
    /// </summary>
    [IsoId("_xp4-ZzbsEead9bDRE_1DAQ")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? StartDate { get; init; }

    /// <summary>
    /// Year and month the card expires.
    /// </summary>
    [IsoId("_xp4-aTbsEead9bDRE_1DAQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public required IsoISOYearMonth ExpiryDate { get; init; }

    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_xp4-azbsEead9bDRE_1DAQ")]
    [DisplayName("Card Issuer Name")]
    [IsoXmlTag("CardIssrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardIssuerName { get; init; }

    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_xp4-bTbsEead9bDRE_1DAQ")]
    [DisplayName("Card Issuer Identification")]
    [IsoXmlTag("CardIssrId")]
    public PartyIdentification113? CardIssuerIdentification { get; init; }

    /// <summary>
    /// Security code written on, or in, the card.
    /// </summary>
    [IsoId("_xp4-bzbsEead9bDRE_1DAQ")]
    [DisplayName("Security Code")]
    [IsoXmlTag("SctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecurityCode { get; init; }

    /// <summary>
    /// Number distinguishing two or more payment cards with the same account number.
    /// </summary>
    [IsoId("_xp4-cTbsEead9bDRE_1DAQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? SequenceNumber { get; init; }
}
