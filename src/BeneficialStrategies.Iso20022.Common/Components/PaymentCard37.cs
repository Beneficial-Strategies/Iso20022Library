// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Card37.
/// </summary>
[IsoId("_MmDGgZ9eEe-nbM0aSPcoiQ")]
[DisplayName("Payment Card37")]
public partial record PaymentCard37
{
    #nullable enable

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
    /// Electronic Purse Balance.
    /// </summary>
    [DisplayName("Electronic Purse Balance")]
    [IsoXmlTag("ElctrncPrsBal")]
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; } 

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
    public PlainCardData24? PlainCardData { get; init; } 

    /// <summary>
    /// Protected Card Data.
    /// </summary>
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; } 

    
    #nullable disable
    
}
