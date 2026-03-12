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
[IsoId("_eHaZsJx0EeuwYeL1lHu9zw")]
[DisplayName("Token")]
public partial record Token3
{
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_UWuGQZx1EeuwYeL1lHu9zw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PaymentToken { get; init; } 
    
    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_XmspQZx1EeuwYeL1lHu9zw")]
    [DisplayName("Token Expiry Date")]
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? TokenExpiryDate { get; init; } 
    
    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_f9WyMZx1EeuwYeL1lHu9zw")]
    [DisplayName("Token Requestor Identification")]
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; } 
    
    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_Z5LCMZx1EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Data")]
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TokenAssuranceData { get; init; } 
    
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_b9fDUZx1EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Method")]
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    
    /// <summary>
    /// A reference to the token.
    /// </summary>
    [IsoId("_kyOSEcmpEeuF1f85xf6dbg")]
    [DisplayName("Token Reference Identification")]
    [IsoXmlTag("TknRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TokenReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Original transaction was initiated by Token.
    /// </summary>
    [IsoId("_IQTfUZx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Initiated Indicator")]
    [IsoXmlTag("TknInittdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; } 
    
    /// <summary>
    /// Storage location of the token.
    /// </summary>
    [IsoId("_y0c9kZyBEeuo7tDc4CDHXg")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public StorageLocation1Code? StorageLocation { get; init; } 
    
    /// <summary>
    /// Other private or national storage location code.
    /// </summary>
    [IsoId("_0oB0AZyBEeuo7tDc4CDHXg")]
    [DisplayName("Other Storage Location")]
    [IsoXmlTag("OthrStorgLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherStorageLocation { get; init; } 
    
    /// <summary>
    /// Method used to protect the token.
    /// </summary>
    [IsoId("_3hab8ZyBEeuo7tDc4CDHXg")]
    [DisplayName("Protection Method")]
    [IsoXmlTag("PrtcnMtd")]
    public ProtectionMethod1Code? ProtectionMethod { get; init; } 
    
    /// <summary>
    /// Other national or private protection method code.
    /// </summary>
    [IsoId("_6PsAEZyBEeuo7tDc4CDHXg")]
    [DisplayName("Other Protection Method")]
    [IsoXmlTag("OthrPrtcnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherProtectionMethod { get; init; } 
    
    /// <summary>
    /// Original token.
    /// </summary>
    [IsoId("_LhGFMJx8EeuwYeL1lHu9zw")]
    [DisplayName("Original Token")]
    [IsoXmlTag("OrgnlTkn")]
    public Token4? OriginalToken { get; init; } 
    
    /// <summary>
    /// Additional token data.
    /// </summary>
    [IsoId("_8tvW4ZyBEeuo7tDc4CDHXg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
