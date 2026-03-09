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
/// Currency control related document or letter supporting the contract registration.
/// </summary>
[IsoId("_r7UcEbGJEeuSTr8k0UEM8A")]
[DisplayName("Supporting Document Request Or Letter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SupportingDocumentRequestOrLetter3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SupportingDocumentRequestOrLetter3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SupportingDocumentRequestOrLetter3( System.String reqRequestOrLetterIdentification,System.String reqSubject,SupportLetterType1Choice_ reqType,System.String reqResponseRequired )
    {
        RequestOrLetterIdentification = reqRequestOrLetterIdentification;
        Subject = reqSubject;
        Type = reqType;
        ResponseRequired = reqResponseRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document request or the letter.
    /// </summary>
    [IsoId("_r8hV8bGJEeuSTr8k0UEM8A")]
    [DisplayName("Request Or Letter Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqOrLttrId")]
    #endif
    [IsoXmlTag("ReqOrLttrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RequestOrLetterIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestOrLetterIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestOrLetterIdentification { get; init; } 
    #else
    public System.String RequestOrLetterIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the supporting document request or the letter.
    /// </summary>
    [IsoId("_r8hV87GJEeuSTr8k0UEM8A")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Sender of the request or letter.
    /// </summary>
    [IsoId("_r8hV9bGJEeuSTr8k0UEM8A")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? Sender { get; init; } 
    #else
    public Party40Choice_? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Receiver of the request or letter.
    /// </summary>
    [IsoId("_r8hV97GJEeuSTr8k0UEM8A")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? Receiver { get; init; } 
    #else
    public Party40Choice_? Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the references of the original underlying message(s) for which supporting documents are requested or for which the letter is sent.
    /// </summary>
    [IsoId("_r8hV-bGJEeuSTr8k0UEM8A")]
    [DisplayName("Original References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRefs")]
    #endif
    [IsoXmlTag("OrgnlRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalMessage4? OriginalReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessage4? OriginalReferences { get; init; } 
    #else
    public OriginalMessage4? OriginalReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Subject of the letter or supporting document.
    /// </summary>
    [IsoId("_r8hV-7GJEeuSTr8k0UEM8A")]
    [DisplayName("Subject")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sbjt")]
    #endif
    [IsoXmlTag("Sbjt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Subject { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Subject { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Subject { get; init; } 
    #else
    public System.String Subject { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the type of supporting document requested.
    /// </summary>
    [IsoId("_r8hV_bGJEeuSTr8k0UEM8A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SupportLetterType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SupportLetterType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportLetterType1Choice_ Type { get; init; } 
    #else
    public SupportLetterType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Further free format description of the request.
    /// </summary>
    [IsoId("_r8hV_7GJEeuSTr8k0UEM8A")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to indicate whether a response is required or not.
    /// Usage: when the request is used to send a letter, there is no response required.
    /// </summary>
    [IsoId("_r8hWAbGJEeuSTr8k0UEM8A")]
    [DisplayName("Response Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnReqrd")]
    #endif
    [IsoXmlTag("RspnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ResponseRequired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResponseRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResponseRequired { get; init; } 
    #else
    public System.String ResponseRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the response to the request is expected.
    /// </summary>
    [IsoId("_r8hWA7GJEeuSTr8k0UEM8A")]
    [DisplayName("Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueDt")]
    #endif
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DueDate { get; init; } 
    #else
    public System.DateOnly? DueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the supporting document request or letter.
    /// </summary>
    [IsoId("_r8hWBbGJEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation5? Attachment { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_r8hWB7GJEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
