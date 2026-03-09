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
/// Defines a business letter containing identifications of involved entities and their roles, references to documents, free form text and signatures.
/// The semantics of this information are defined by usual business practices for the exchange and tracing of business letters. The described references and party identifiers permit to establish a linked informal trace of sequences of letters.
/// This message component contains three types of elements that can be referenced using IDREF:
/// (1) - all elements defining qualified parties,
/// (2) - all elements defining qualified documents or references to them,
/// (3) - the LegalContext element.
/// </summary>
[IsoId("_OTgzMTkz-AOSNFX-8224490")]
[DisplayName("Business Letter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessLetter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BusinessLetter1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessLetter1( QualifiedDocumentInformation1 reqLetterIdentifier,System.DateOnly reqDate,QualifiedPartyIdentification1 reqOriginator )
    {
        LetterIdentifier = reqLetterIdentifier;
        Date = reqDate;
        Originator = reqOriginator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Application context defined by users. This is typically the name of a product.
    /// </summary>
    [IsoId("_OTgzMjAz-AOSNFX-8224491")]
    [DisplayName("Application Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplCntxt")]
    #endif
    [IsoXmlTag("ApplCntxt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationContext { get; init; } 
    #else
    public System.String? ApplicationContext { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identifier for this letter.
    /// </summary>
    [IsoId("_OTgzMjA1-AOSNFX-8224491")]
    [DisplayName("Letter Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrIdr")]
    #endif
    [IsoXmlTag("LttrIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedDocumentInformation1 LetterIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedDocumentInformation1 LetterIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1 LetterIdentifier { get; init; } 
    #else
    public QualifiedDocumentInformation1 LetterIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Purported creation date of the document.
    /// </summary>
    [IsoId("_OTgzMjA2-AOSNFX-8224491")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly Date { get; init; } 
    #else
    public System.DateOnly Date { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a related letter.
    /// </summary>
    [IsoId("_OTgzMjA3-AOSNFX-8224491")]
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
    /// Identifier of a related message.
    /// </summary>
    [IsoId("_OTgzMjA4-AOSNFX-822449")]
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
    /// Cross references the lists that are associated to this letter inside a message. The identifiers are relative to the Originator.
    /// </summary>
    [IsoId("_OTgzMjA5-AOSNFX-8224491")]
    [DisplayName("Content Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnttIdr")]
    #endif
    [IsoXmlTag("CnttIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ContentIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContentIdentifier { get; init; } 
    #else
    public System.String? ContentIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the business letter to apply to the processing of the letter.
    /// </summary>
    [IsoId("_OTgzMjEx-AOSNFX-8224491")]
    [DisplayName("Instruction Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrty")]
    #endif
    [IsoXmlTag("InstrPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority3Code? InstructionPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority3Code? InstructionPriority { get; init; } 
    #else
    public Priority3Code? InstructionPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the originating party of this letter.
    /// </summary>
    [IsoId("_OTgzMjEz-AOSNFX-8224491")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 Originator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 Originator { get; init; } 
    #else
    public QualifiedPartyIdentification1 Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Primary recipient of the business letter. The exact meaning is given by the users.
    /// </summary>
    [IsoId("_OTgzMjE0-AOSNFX-8224491")]
    [DisplayName("Primary Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryRcpt")]
    #endif
    [IsoXmlTag("PmryRcpt")]
    public ValueList<QualifiedPartyIdentification1> PrimaryRecipient { get; init; } = new ValueList<QualifiedPartyIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMjE0-AOSNFX-8224491
    
    /// <summary>
    /// Sender of the business letter. The exact meaning is given by the users.
    /// </summary>
    [IsoId("_OTgzMjE1-AOSNFX-8224492")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Sender { get; init; } 
    #else
    public QualifiedPartyIdentification1? Sender { get; set; } 
    #endif
    
    /// <summary>
    /// User who, either individually or in concert with others, authorises the origination of a message.
    /// </summary>
    [IsoId("_OTgzMjE2-AOSNFX-8224492")]
    [DisplayName("Authorisation User")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnUsr")]
    #endif
    [IsoXmlTag("AuthstnUsr")]
    public ValueList<QualifiedPartyIdentification1> AuthorisationUser { get; init; } = new ValueList<QualifiedPartyIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMjE2-AOSNFX-8224492
    
    /// <summary>
    /// Party to receive a reply to this letter.
    /// </summary>
    [IsoId("_OTgzMjE3-AOSNFX-8224492")]
    [DisplayName("Response Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRcpt")]
    #endif
    [IsoXmlTag("RspnRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? ResponseRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? ResponseRecipient { get; init; } 
    #else
    public QualifiedPartyIdentification1? ResponseRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Party to receive a copy of the message.
    /// </summary>
    [IsoId("_OTgzMjE4-AOSNFX-8224492")]
    [DisplayName("Copy Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyRcpt")]
    #endif
    [IsoXmlTag("CpyRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? CopyRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? CopyRecipient { get; init; } 
    #else
    public QualifiedPartyIdentification1? CopyRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Other party involved. This element is usable as a target for IDREFs.
    /// </summary>
    [IsoId("_OTgzMjE5-AOSNFX-8224492")]
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
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMjIw-AOSNFX-8224493")]
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
    /// Governing contract.
    /// </summary>
    [IsoId("_OTgzMjIx-AOSNFX-8224493")]
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
    /// Rules and laws governing the letter.
    /// </summary>
    [IsoId("_OTgzMjIz-AOSNFX-8224493")]
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
    
    /// <summary>
    /// Free form information about this message.
    /// </summary>
    [IsoId("_OTgzMjI0-AOSNFX-8224493")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2000Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Free form information unrelated to the message for example advertising or a service notice.
    /// </summary>
    [IsoId("_OTgzMjI1-AOSNFX-8224493")]
    [DisplayName("Notice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntce")]
    #endif
    [IsoXmlTag("Ntce")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Notice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Notice { get; init; } 
    #else
    public System.String? Notice { get; set; } 
    #endif
    
    /// <summary>
    /// Status of referenced messages or letters.
    /// </summary>
    [IsoId("_OTgzMjI2-AOSNFX-8224493")]
    [DisplayName("Validation Status Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnStsInf")]
    #endif
    [IsoXmlTag("VldtnStsInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; } 
    #else
    public ValidationStatusInformation1? ValidationStatusInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signatures and signing parties of this letter or parts of it.
    /// </summary>
    [IsoId("_OTgzMjI4-AOSNFX-8224493")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyAndXMLSignature1? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyAndXMLSignature1? DigitalSignature { get; init; } 
    #else
    public QualifiedPartyAndXMLSignature1? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
