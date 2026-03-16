// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Card36.
/// </summary>
[IsoId("_Zei4YZ9dEe-nbM0aSPcoiQ")]
[DisplayName("Payment Card36")]
public record PaymentCard36
{
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
    /// Card Data Entry Mode.
    /// </summary>
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public required CardDataReading1Code CardDataEntryMode { get; init; }

    /// <summary>
    /// Fallback Indicator.
    /// </summary>
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    public IsoTrueFalseIndicator? FallbackIndicator { get; init; }

    /// <summary>
    /// Plain Card Data.
    /// </summary>
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData25? PlainCardData { get; init; }

    /// <summary>
    /// Protected Card Data.
    /// </summary>
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }
}
