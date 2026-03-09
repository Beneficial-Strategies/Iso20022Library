// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the ATM terminal.
/// </summary>
[IsoId("_uehdQYn6EeShMpas3885ww")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the ATM performing the transaction.
    /// </summary>
    [IsoId("_uqvUUYn6EeShMpas3885ww")]
    [DisplayName("Card Read Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdData")]
    #endif
    [IsoXmlTag("CardRdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading4Code? CardReadData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading4Code? CardReadData { get; init; } 
    #else
    public CardDataReading4Code? CardReadData { get; set; } 
    #endif
    
    /// <summary>
    /// Card writing capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_UHJrcIn7EeShMpas3885ww")]
    [DisplayName("Card Write Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardWrtData")]
    #endif
    [IsoXmlTag("CardWrtData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading4Code? CardWriteData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading4Code? CardWriteData { get; init; } 
    #else
    public CardDataReading4Code? CardWriteData { get; set; } 
    #endif
    
    /// <summary>
    /// Customer and card authentication capabilities available at the ATM.
    /// </summary>
    [IsoId("_uqvUU4n6EeShMpas3885ww")]
    [DisplayName("Authentication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authntcn")]
    #endif
    [IsoXmlTag("Authntcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability3Code? Authentication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability3Code? Authentication { get; init; } 
    #else
    public CardholderVerificationCapability3Code? Authentication { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the ATM is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_uqvUVYn6EeShMpas3885ww")]
    [DisplayName("PIN Length Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINLngthCpblties")]
    #endif
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PINLengthCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapabilities { get; init; } 
    #else
    public System.UInt64? PINLengthCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of characters of the approval code the ATM is able to manage.
    /// </summary>
    [IsoId("_uqvUV4n6EeShMpas3885ww")]
    [DisplayName("Approval Code Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlCdLngth")]
    #endif
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ApprovalCodeLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ApprovalCodeLength { get; init; } 
    #else
    public System.UInt64? ApprovalCodeLength { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_XMgnoC7zEeWc7f-D6ByqMg")]
    [DisplayName("Max Script Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MxScrptLngth")]
    #endif
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaxScriptLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaxScriptLength { get; init; } 
    #else
    public System.UInt64? MaxScriptLength { get; set; } 
    #endif
    
    /// <summary>
    /// True if the ATM is able to capture card.
    /// </summary>
    [IsoId("_uqvUWYn6EeShMpas3885ww")]
    [DisplayName("Card Capture Capable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCaptrCpbl")]
    #endif
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCaptureCapable { get; init; } 
    #else
    public System.String? CardCaptureCapable { get; set; } 
    #endif
    
    
    #nullable disable
    
}
