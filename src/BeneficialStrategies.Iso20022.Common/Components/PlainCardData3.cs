// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensible data associated with the payment card performing the transaction provided for verification in response.
/// </summary>
[IsoId("_Sp--2gEcEeCQm6a_G2yO_w_736718195")]
[DisplayName("Plain Card Data")]
public partial record PlainCardData3
{
    #nullable enable
    
    /// <summary>
    /// Primary Account Number (PAN) of the card, or card number.
    /// </summary>
    [IsoId("_Sp--2wEcEeCQm6a_G2yO_w_704747431")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; } 
    
    /// <summary>
    /// Identify a card inside a set of cards with the same card number (PAN).
    /// </summary>
    [IsoId("_Sp--3AEcEeCQm6a_G2yO_w_-265175132")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_Sp--3QEcEeCQm6a_G2yO_w_1590202939")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Expiry date of the card.
    /// </summary>
    [IsoId("_SqIIwAEcEeCQm6a_G2yO_w_-1367044960")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public required IsoISOYearMonth ExpiryDate { get; init; } 
    
    
    #nullable disable
    
}
