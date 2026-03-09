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
/// Describes an event not covered by other formal messages, for example a trace after a telephone call.
/// </summary>
[IsoId("_OTgzMjAx-AOSNFX-8224490")]
[DisplayName("Event Description")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventDescription1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventDescription1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventDescription1( System.String reqIdentifier,QualifiedPartyIdentification1 reqRecipient,QualifiedPartyIdentification1 reqAdvisor,string reqLanguageCode,System.String reqDescription )
    {
        Identifier = reqIdentifier;
        Recipient = reqRecipient;
        Advisor = reqAdvisor;
        LanguageCode = reqLanguageCode;
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the event.
    /// </summary>
    [IsoId("_OTgzMjU5-AOSNFX-8224494")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date when event occurred.
    /// </summary>
    [IsoId("_OTgzMjYw-AOSNFX-8224494")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? Date { get; init; } 
    #else
    public System.DateTime? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Party to be advised.
    /// </summary>
    [IsoId("_OTgzMjYx-AOSNFX-8224494")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Recipient { get; init; } 
    #else
    public QualifiedPartyIdentification1 Recipient { get; set; } 
    #endif
    
    /// <summary>
    /// Advising party.
    /// </summary>
    [IsoId("_OTgzMjYy-AOSNFX-8224494")]
    [DisplayName("Advisor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Advsr")]
    #endif
    [IsoXmlTag("Advsr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Advisor { get; init; } 
    #else
    public QualifiedPartyIdentification1 Advisor { get; set; } 
    #endif
    
    /// <summary>
    /// Parties involved in the event.
    /// </summary>
    [IsoId("_OTgzMjYz-AOSNFX-8224495")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? OtherParty { get; init; } 
    #else
    public QualifiedPartyIdentification1? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier for a language used for the description.
    /// </summary>
    [IsoId("_OTgzMjY0-AOSNFX-8224495")]
    [DisplayName("Language Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LangCd")]
    #endif
    [IsoXmlTag("LangCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LanguageCode LanguageCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string LanguageCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string LanguageCode { get; init; } 
    #else
    public string LanguageCode { get; set; } 
    #endif
    
    /// <summary>
    /// Free form description of event.
    /// </summary>
    [IsoId("_OTgzMjY1-AOSNFX-8224495")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2000Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to related document.
    /// </summary>
    [IsoId("_OTgzMjY2-AOSNFX-8224495")]
    [DisplayName("Related Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDoc")]
    #endif
    [IsoXmlTag("RltdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of related letter.
    /// </summary>
    [IsoId("_OTgzMjY3-AOSNFX-8224495")]
    [DisplayName("Related Letter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdLttr")]
    #endif
    [IsoXmlTag("RltdLttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedLetter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedLetter { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedLetter { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of related message.
    /// </summary>
    [IsoId("_OTgzMjY4-AOSNFX-8224495")]
    [DisplayName("Related Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdMsg")]
    #endif
    [IsoXmlTag("RltdMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedMessage { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedMessage { get; set; } 
    #endif
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMjY5-AOSNFX-8224495")]
    [DisplayName("Associated Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDoc")]
    #endif
    [IsoXmlTag("AssoctdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    #else
    public QualifiedDocumentInformation1? AssociatedDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the contractual context.
    /// </summary>
    [IsoId("_OTgzMjcw-AOSNFX-8224495")]
    [DisplayName("Governing Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovngCtrct")]
    #endif
    [IsoXmlTag("GovngCtrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    #else
    public QualifiedDocumentInformation1? GoverningContract { get; set; } 
    #endif
    
    /// <summary>
    /// Rules and laws governing the event.
    /// </summary>
    [IsoId("_OTgzMjcx-AOSNFX-8224495")]
    [DisplayName("Legal Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglCntxt")]
    #endif
    [IsoXmlTag("LglCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GovernanceRules2? LegalContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceRules2? LegalContext { get; init; } 
    #else
    public GovernanceRules2? LegalContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
