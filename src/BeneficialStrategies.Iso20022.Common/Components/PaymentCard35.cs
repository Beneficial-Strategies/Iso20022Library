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
    /// Protected Card Data.
    /// </summary>
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType40? ProtectedCardData { get; init; }

    /// <summary>
    /// Private Card Data.
    /// </summary>
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    public Max100KBinary? PrivateCardData { get; init; }

    /// <summary>
    /// Plain Card Data.
    /// </summary>
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData22? PlainCardData { get; init; }

    /// <summary>
    /// Payment Account Reference.
    /// </summary>
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public Max70Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Masked PAN.
    /// </summary>
    [DisplayName("Masked PAN")]
    [IsoXmlTag("MskdPAN")]
    public Max30Text? MaskedPAN { get; init; }

    /// <summary>
    /// Issuer BIN.
    /// </summary>
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    public Max15NumericText? IssuerBIN { get; init; }

    /// <summary>
    /// Card Country Code.
    /// </summary>
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    public Max3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Card Currency Code.
    /// </summary>
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    public Exact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Card Product Profile.
    /// </summary>
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    public Max35Text? CardProductProfile { get; init; }

    /// <summary>
    /// Card Brand.
    /// </summary>
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    public Max35Text? CardBrand { get; init; }

    /// <summary>
    /// Card Product Type.
    /// </summary>
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    public CardProductType1Code? CardProductType { get; init; }

    /// <summary>
    /// Card Product Sub Type.
    /// </summary>
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    public Max35Text? CardProductSubType { get; init; }

    /// <summary>
    /// International Card.
    /// </summary>
    [DisplayName("International Card")]
    [IsoXmlTag("IntrnlCard")]
    public TrueFalseIndicator? InternationalCard { get; init; }

    /// <summary>
    /// Allowed Product.
    /// </summary>
    [DisplayName("Allowed Product")]
    [IsoXmlTag("AllwdPdct")]
    public ValueList<Max70Text> AllowedProduct { get; init; } = [];

    /// <summary>
    /// Service Option.
    /// </summary>
    [DisplayName("Service Option")]
    [IsoXmlTag("SvcOptn")]
    public Max35Text? ServiceOption { get; init; }

    /// <summary>
    /// Additional Card Data.
    /// </summary>
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public Max70Text? AdditionalCardData { get; init; }
}
