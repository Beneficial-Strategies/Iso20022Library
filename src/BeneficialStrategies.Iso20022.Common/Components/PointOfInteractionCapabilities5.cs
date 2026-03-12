// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the ATM terminal.
/// </summary>
[IsoId("_uehdQYn6EeShMpas3885ww")]
[DisplayName("Point Of Interaction Capabilities")]
public partial record PointOfInteractionCapabilities5
{
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the ATM performing the transaction.
    /// </summary>
    [IsoId("_uqvUUYn6EeShMpas3885ww")]
    [DisplayName("Card Read Data")]
    [IsoXmlTag("CardRdData")]
    public CardDataReading4Code? CardReadData { get; init; } 
    
    /// <summary>
    /// Card writing capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_UHJrcIn7EeShMpas3885ww")]
    [DisplayName("Card Write Data")]
    [IsoXmlTag("CardWrtData")]
    public CardDataReading4Code? CardWriteData { get; init; } 
    
    /// <summary>
    /// Customer and card authentication capabilities available at the ATM.
    /// </summary>
    [IsoId("_uqvUU4n6EeShMpas3885ww")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderVerificationCapability3Code? Authentication { get; init; } 
    
    /// <summary>
    /// Maximum number of digits the ATM is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_uqvUVYn6EeShMpas3885ww")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; } 
    
    /// <summary>
    /// Maximum number of characters of the approval code the ATM is able to manage.
    /// </summary>
    [IsoId("_uqvUV4n6EeShMpas3885ww")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; } 
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_XMgnoC7zEeWc7f-D6ByqMg")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaxScriptLength { get; init; } 
    
    /// <summary>
    /// True if the ATM is able to capture card.
    /// </summary>
    [IsoId("_uqvUWYn6EeShMpas3885ww")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    
    
    #nullable disable
    
}
