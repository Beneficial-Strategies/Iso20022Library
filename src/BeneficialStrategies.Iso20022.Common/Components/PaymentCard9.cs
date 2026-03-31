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
[IsoId("_qcddgWiyEeS87LmvcA55sg")]
[DisplayName("Payment Card")]
public record PaymentCard9
{
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_qqR3EWiyEeS87LmvcA55sg")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_qqR3E2iyEeS87LmvcA55sg")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData7? PlainCardData { get; init; }

    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_RxcvwGjHEeSHBr6v3XO0Mg")]
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? IssuerBIN { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_qqR3FWiyEeS87LmvcA55sg")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_qqR3F2iyEeS87LmvcA55sg")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_qqR3GWiyEeS87LmvcA55sg")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductProfile { get; init; }

    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_qqR3G2iyEeS87LmvcA55sg")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_qqR3HWiyEeS87LmvcA55sg")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; }
}
