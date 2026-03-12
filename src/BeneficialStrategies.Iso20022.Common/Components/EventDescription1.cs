// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes an event not covered by other formal messages, for example a trace after a telephone call.
/// </summary>
[IsoId("_OTgzMjAx-AOSNFX-8224490")]
[DisplayName("Event Description")]
public partial record EventDescription1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the event.
    /// </summary>
    [IsoId("_OTgzMjU5-AOSNFX-8224494")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; } 
    
    /// <summary>
    /// Date when event occurred.
    /// </summary>
    [IsoId("_OTgzMjYw-AOSNFX-8224494")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? Date { get; init; } 
    
    /// <summary>
    /// Party to be advised.
    /// </summary>
    [IsoId("_OTgzMjYx-AOSNFX-8224494")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required QualifiedPartyIdentification1 Recipient { get; init; } 
    
    /// <summary>
    /// Advising party.
    /// </summary>
    [IsoId("_OTgzMjYy-AOSNFX-8224494")]
    [DisplayName("Advisor")]
    [IsoXmlTag("Advsr")]
    public required QualifiedPartyIdentification1 Advisor { get; init; } 
    
    /// <summary>
    /// Parties involved in the event.
    /// </summary>
    [IsoId("_OTgzMjYz-AOSNFX-8224495")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public QualifiedPartyIdentification1? OtherParty { get; init; } 
    
    /// <summary>
    /// Identifier for a language used for the description.
    /// </summary>
    [IsoId("_OTgzMjY0-AOSNFX-8224495")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public required LanguageCode LanguageCode { get; init; } 
    
    /// <summary>
    /// Free form description of event.
    /// </summary>
    [IsoId("_OTgzMjY1-AOSNFX-8224495")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public required IsoMax2000Text Description { get; init; } 
    
    /// <summary>
    /// Reference to related document.
    /// </summary>
    [IsoId("_OTgzMjY2-AOSNFX-8224495")]
    [DisplayName("Related Document")]
    [IsoXmlTag("RltdDoc")]
    public QualifiedDocumentInformation1? RelatedDocument { get; init; } 
    
    /// <summary>
    /// Identifier of related letter.
    /// </summary>
    [IsoId("_OTgzMjY3-AOSNFX-8224495")]
    [DisplayName("Related Letter")]
    [IsoXmlTag("RltdLttr")]
    public QualifiedDocumentInformation1? RelatedLetter { get; init; } 
    
    /// <summary>
    /// Identifier of related message.
    /// </summary>
    [IsoId("_OTgzMjY4-AOSNFX-8224495")]
    [DisplayName("Related Message")]
    [IsoXmlTag("RltdMsg")]
    public QualifiedDocumentInformation1? RelatedMessage { get; init; } 
    
    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMjY5-AOSNFX-8224495")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; } 
    
    /// <summary>
    /// Reference to the contractual context.
    /// </summary>
    [IsoId("_OTgzMjcw-AOSNFX-8224495")]
    [DisplayName("Governing Contract")]
    [IsoXmlTag("GovngCtrct")]
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    
    /// <summary>
    /// Rules and laws governing the event.
    /// </summary>
    [IsoId("_OTgzMjcx-AOSNFX-8224495")]
    [DisplayName("Legal Context")]
    [IsoXmlTag("LglCntxt")]
    public GovernanceRules2? LegalContext { get; init; } 
    
    
    #nullable disable
    
}
