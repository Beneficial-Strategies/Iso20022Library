// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unencrypted sensitive data of a token.
/// </summary>
[IsoId("_dJ3vMZx7EeuwYeL1lHu9zw")]
[DisplayName("Token")]
public partial record Token4
{
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_dPa9kZx7EeuwYeL1lHu9zw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PaymentToken { get; init; } 
    
    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_dPa9k5x7EeuwYeL1lHu9zw")]
    [DisplayName("Token Expiry Date")]
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? TokenExpiryDate { get; init; } 
    
    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_dPa9lZx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Requestor Identification")]
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; } 
    
    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_dPa9l5x7EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Data")]
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TokenAssuranceData { get; init; } 
    
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_dPa9mZx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Method")]
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    
    /// <summary>
    /// A reference to the token.
    /// </summary>
    [IsoId("_6BoksJx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Reference Identification")]
    [IsoXmlTag("TknRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TokenReferenceIdentification { get; init; } 
    
    
    #nullable disable
    
}
