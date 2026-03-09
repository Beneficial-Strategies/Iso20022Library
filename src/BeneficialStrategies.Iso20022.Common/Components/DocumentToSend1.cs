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
/// Determine the type of document and the type of communication method to be used to notify a Party.
/// </summary>
[IsoId("_RTCTPtp-Ed-ak6NoX_4Aeg_436078909")]
[DisplayName("Document To Send")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentToSend1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentToSend1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentToSend1( System.String reqType,PartyIdentification2Choice_ reqRecipient,CommunicationMethod1Code reqMethodOfTransmission,System.String reqExtendedMethodOfTransmission )
    {
        Type = reqType;
        Recipient = reqRecipient;
        MethodOfTransmission = reqMethodOfTransmission;
        ExtendedMethodOfTransmission = reqExtendedMethodOfTransmission;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_RTCTP9p-Ed-ak6NoX_4Aeg_1009585509")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    [IsoId("_RTCTQNp-Ed-ak6NoX_4Aeg_1020668296")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ Recipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ Recipient { get; init; } 
    #else
    public PartyIdentification2Choice_ Recipient { get; set; } 
    #endif
    
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    [IsoId("_RTCTQdp-Ed-ak6NoX_4Aeg_1018819949")]
    [DisplayName("Method Of Transmission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtdOfTrnsmssn")]
    #endif
    [IsoXmlTag("MtdOfTrnsmssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationMethod1Code MethodOfTransmission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationMethod1Code MethodOfTransmission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationMethod1Code MethodOfTransmission { get; init; } 
    #else
    public CommunicationMethod1Code MethodOfTransmission { get; set; } 
    #endif
    
    /// <summary>
    /// Communication means used to send information.
    /// </summary>
    [IsoId("_RTLdINp-Ed-ak6NoX_4Aeg_-506656279")]
    [DisplayName("Extended Method Of Transmission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedMtdOfTrnsmssn")]
    #endif
    [IsoXmlTag("XtndedMtdOfTrnsmssn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedMethodOfTransmission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedMethodOfTransmission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedMethodOfTransmission { get; init; } 
    #else
    public System.String ExtendedMethodOfTransmission { get; set; } 
    #endif
    
    
    #nullable disable
    
}
