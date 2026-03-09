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
[IsoId("_nwovca1yEeWMg5rOByfExw")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities7
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
    [IsoId("_n8Qwoa1yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwo61yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwpa1yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwp61yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwqa1yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwq61yEeWMg5rOByfExw")]
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
    [IsoId("_n8Qwra1yEeWMg5rOByfExw")]
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
    
    /// <summary>
    /// Type of media the ATM is able to dispense.
    /// </summary>
    [IsoId("_zXT3oK1yEeWMg5rOByfExw")]
    [DisplayName("Withdrawal Media")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlMdia")]
    #endif
    [IsoXmlTag("WdrwlMdia")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaType1Code? WithdrawalMedia { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType1Code? WithdrawalMedia { get; init; } 
    #else
    public ATMMediaType1Code? WithdrawalMedia { get; set; } 
    #endif
    
    /// <summary>
    /// Type of media the customer is able to deposit in the ATM.
    /// </summary>
    [IsoId("_432IAK1yEeWMg5rOByfExw")]
    [DisplayName("Deposited Media")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstdMdia")]
    #endif
    [IsoXmlTag("DpstdMdia")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaType2Code? DepositedMedia { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType2Code? DepositedMedia { get; init; } 
    #else
    public ATMMediaType2Code? DepositedMedia { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_-GjBgK1yEeWMg5rOByfExw")]
    [DisplayName("Message Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCpblties")]
    #endif
    [IsoXmlTag("MsgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities5? MessageCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities5? MessageCapabilities { get; init; } 
    #else
    public DisplayCapabilities5? MessageCapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
