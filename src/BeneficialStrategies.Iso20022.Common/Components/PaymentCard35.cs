// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Card35.
/// </summary>
[IsoId("__UZVMY-YEe6oobnCtR50kw")]
[DisplayName("Payment Card35")]
public record PaymentCard35
{
    /// <summary>
    /// Additional Card Data.
    /// </summary>
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public IsoMax70Text? AdditionalCardData { get; init; }

    /// <summary>
    /// Allowed Product.
    /// </summary>
    [DisplayName("Allowed Product")]
    [IsoXmlTag("AllwdPdct")]
    public ValueList<IsoMax70Text> AllowedProduct { get; init; } = [];

    /// <summary>
    /// Card Brand.
    /// </summary>
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    public IsoMax35Text? CardBrand { get; init; }

    /// <summary>
    /// Card Country Code.
    /// </summary>
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Card Currency Code.
    /// </summary>
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Card Product Profile.
    /// </summary>
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    public IsoMax35Text? CardProductProfile { get; init; }

    /// <summary>
    /// Card Product Sub Type.
    /// </summary>
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    public IsoMax35Text? CardProductSubType { get; init; }

    /// <summary>
    /// Card Product Type.
    /// </summary>
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    public CardProductType1Code? CardProductType { get; init; }

    /// <summary>
    /// International Card.
    /// </summary>
    [DisplayName("International Card")]
    [IsoXmlTag("IntrnlCard")]
    public IsoTrueFalseIndicator? InternationalCard { get; init; }

    /// <summary>
    /// Issuer BIN.
    /// </summary>
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    public IsoMax15NumericText? IssuerBIN { get; init; }

    /// <summary>
    /// Masked PAN.
    /// </summary>
    [DisplayName("Masked PAN")]
    [IsoXmlTag("MskdPAN")]
    public IsoMax30Text? MaskedPAN { get; init; }

    /// <summary>
    /// Payment Account Reference.
    /// </summary>
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public IsoMax70Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Plain Card Data.
    /// </summary>
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData22? PlainCardData { get; init; }

    /// <summary>
    /// Private Card Data.
    /// </summary>
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    public IsoMax100KBinary? PrivateCardData { get; init; }

    /// <summary>
    /// Protected Card Data.
    /// </summary>
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType40? ProtectedCardData { get; init; }

    /// <summary>
    /// Service Option.
    /// </summary>
    [DisplayName("Service Option")]
    [IsoXmlTag("SvcOptn")]
    public IsoMax35Text? ServiceOption { get; init; }
}
