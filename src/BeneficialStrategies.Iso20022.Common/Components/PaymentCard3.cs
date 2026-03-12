// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
[IsoId("_Sqk0vQEcEeCQm6a_G2yO_w_-767368114")]
[DisplayName("Payment Card")]
public partial record PaymentCard3
{
    #nullable enable
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_Sqk0vgEcEeCQm6a_G2yO_w_-279742338")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType2? ProtectedCardData { get; init; } 
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_SqulsAEcEeCQm6a_G2yO_w_1453352557")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData2? PlainCardData { get; init; } 
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_SqulsQEcEeCQm6a_G2yO_w_-79537271")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? CardCountryCode { get; init; } 
    
    /// <summary>
    /// Defines a category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_SqulsgEcEeCQm6a_G2yO_w_926879624")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? CardProductProfile { get; init; } 
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_SqulswEcEeCQm6a_G2yO_w_-675257507")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; } 
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_SqultAEcEeCQm6a_G2yO_w_364776788")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
    
    #nullable disable
    
}
