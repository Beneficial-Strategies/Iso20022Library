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
/// Defines the criteria to extract the message(s) which should be resent.
/// </summary>
[IsoId("_Q6TwEZb7Eee4htziCyV8eA")]
[DisplayName("Resend Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResendSearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResendSearchCriteria2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResendSearchCriteria2( PartyIdentification136 reqRecipient )
    {
        Recipient = reqRecipient;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the business day of the requested messages the resend function is used for.
    /// </summary>
    [IsoId("_RDPCkZb7Eee4htziCyV8eA")]
    [DisplayName("Business Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizDt")]
    #endif
    [IsoXmlTag("BizDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BusinessDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BusinessDate { get; init; } 
    #else
    public System.DateOnly? BusinessDate { get; set; } 
    #endif
    
    /// <summary>
    /// Independent counter for message sequence, which is available once per party technical address.|Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_RDPCk5b7Eee4htziCyV8eA")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Independent counter for a range of message sequences, which are available once per party technical address.
    /// Specifies the range of identification sequence numbers for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_UsXFYJb7Eee4htziCyV8eA")]
    [DisplayName("Sequence Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqRg")]
    #endif
    [IsoXmlTag("SeqRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SequenceRange1Choice_? SequenceRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SequenceRange1Choice_? SequenceRange { get; init; } 
    #else
    public SequenceRange1Choice_? SequenceRange { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguously identifies the original bsiness message, which was delivered by the business sender.
    /// </summary>
    [IsoId("_RDPClZb7Eee4htziCyV8eA")]
    [DisplayName("Original Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgNmId")]
    #endif
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMessageNameIdentification { get; init; } 
    #else
    public System.String? OriginalMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_RDPCl5b7Eee4htziCyV8eA")]
    [DisplayName("File Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileRef")]
    #endif
    [IsoXmlTag("FileRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FileReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileReference { get; init; } 
    #else
    public System.String? FileReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify the recipient of the report message.
    /// </summary>
    [IsoId("_RDPCmZb7Eee4htziCyV8eA")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136 Recipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136 Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136 Recipient { get; init; } 
    #else
    public PartyIdentification136 Recipient { get; set; } 
    #endif
    
    
    #nullable disable
    
}
