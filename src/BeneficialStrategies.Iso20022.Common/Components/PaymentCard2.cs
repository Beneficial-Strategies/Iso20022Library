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
[IsoId("_QRxDedp-Ed-ak6NoX_4Aeg_137953506")]
[DisplayName("Payment Card")]
public record PaymentCard2
{
    /// <summary>
    /// Type of card, eg, credit card.
    /// </summary>
    [IsoId("_QRxDetp-Ed-ak6NoX_4Aeg_137953532")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardType1Code Type { get; init; }

    /// <summary>
    /// Number embossed on a card that links the card to the account owner and account servicer.
    /// </summary>
    [IsoId("_QRxDe9p-Ed-ak6NoX_4Aeg_137953548")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }

    /// <summary>
    /// Party entitled by a card issuer to use a card.
    /// </summary>
    [IsoId("_QRxDfNp-Ed-ak6NoX_4Aeg_137953566")]
    [DisplayName("Holder Name")]
    [IsoXmlTag("HldrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HolderName { get; init; }

    /// <summary>
    /// Year and month the card is available for use.
    /// </summary>
    [IsoId("_QR60cNp-Ed-ak6NoX_4Aeg_137953583")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? StartDate { get; init; }

    /// <summary>
    /// Year and month the card expires.
    /// </summary>
    [IsoId("_QR60cdp-Ed-ak6NoX_4Aeg_137953601")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public required IsoISOYearMonth ExpiryDate { get; init; }

    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_QR60ctp-Ed-ak6NoX_4Aeg_137953626")]
    [DisplayName("Card Issuer Name")]
    [IsoXmlTag("CardIssrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardIssuerName { get; init; }

    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_QR60c9p-Ed-ak6NoX_4Aeg_137953643")]
    [DisplayName("Card Issuer Identification")]
    [IsoXmlTag("CardIssrId")]
    public PartyIdentification2Choice_? CardIssuerIdentification { get; init; }

    /// <summary>
    /// Security code written on, or in, the card.
    /// </summary>
    [IsoId("_QR60dNp-Ed-ak6NoX_4Aeg_137953934")]
    [DisplayName("Security Code")]
    [IsoXmlTag("SctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecurityCode { get; init; }

    /// <summary>
    /// Number distinguishing two or more payment cards with the same account number.
    /// </summary>
    [IsoId("_QR60ddp-Ed-ak6NoX_4Aeg_137953951")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? SequenceNumber { get; init; }
}
