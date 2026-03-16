// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

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
public record BusinessLetter1
{
    /// <summary>
    /// Application context defined by users. This is typically the name of a product.
    /// </summary>
    [IsoId("_OTgzMjAz-AOSNFX-8224491")]
    [DisplayName("Application Context")]
    [IsoXmlTag("ApplCntxt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationContext { get; init; }

    /// <summary>
    /// Unambiguous identifier for this letter.
    /// </summary>
    [IsoId("_OTgzMjA1-AOSNFX-8224491")]
    [DisplayName("Letter Identifier")]
    [IsoXmlTag("LttrIdr")]
    public required QualifiedDocumentInformation1 LetterIdentifier { get; init; }

    /// <summary>
    /// Purported creation date of the document.
    /// </summary>
    [IsoId("_OTgzMjA2-AOSNFX-8224491")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Identifier of a related letter.
    /// </summary>
    [IsoId("_OTgzMjA3-AOSNFX-8224491")]
    [DisplayName("Related Letter")]
    [IsoXmlTag("RltdLttr")]
    public QualifiedDocumentInformation1? RelatedLetter { get; init; }

    /// <summary>
    /// Identifier of a related message.
    /// </summary>
    [IsoId("_OTgzMjA4-AOSNFX-822449")]
    [DisplayName("Related Message")]
    [IsoXmlTag("RltdMsg")]
    public QualifiedDocumentInformation1? RelatedMessage { get; init; }

    /// <summary>
    /// Cross references the lists that are associated to this letter inside a message. The identifiers are relative to the Originator.
    /// </summary>
    [IsoId("_OTgzMjA5-AOSNFX-8224491")]
    [DisplayName("Content Identifier")]
    [IsoXmlTag("CnttIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContentIdentifier { get; init; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the business letter to apply to the processing of the letter.
    /// </summary>
    [IsoId("_OTgzMjEx-AOSNFX-8224491")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <summary>
    /// Identification of the originating party of this letter.
    /// </summary>
    [IsoId("_OTgzMjEz-AOSNFX-8224491")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public required QualifiedPartyIdentification1 Originator { get; init; }

    /// <summary>
    /// Primary recipient of the business letter. The exact meaning is given by the users.
    /// </summary>
    [IsoId("_OTgzMjE0-AOSNFX-8224491")]
    [DisplayName("Primary Recipient")]
    [IsoXmlTag("PmryRcpt")]
    public ValueList<QualifiedPartyIdentification1> PrimaryRecipient { get; init; } = [];

    // ID for the above is _OTgzMjE0-AOSNFX-8224491

    /// <summary>
    /// Sender of the business letter. The exact meaning is given by the users.
    /// </summary>
    [IsoId("_OTgzMjE1-AOSNFX-8224492")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public QualifiedPartyIdentification1? Sender { get; init; }

    /// <summary>
    /// User who, either individually or in concert with others, authorises the origination of a message.
    /// </summary>
    [IsoId("_OTgzMjE2-AOSNFX-8224492")]
    [DisplayName("Authorisation User")]
    [IsoXmlTag("AuthstnUsr")]
    public ValueList<QualifiedPartyIdentification1> AuthorisationUser { get; init; } = [];

    // ID for the above is _OTgzMjE2-AOSNFX-8224492

    /// <summary>
    /// Party to receive a reply to this letter.
    /// </summary>
    [IsoId("_OTgzMjE3-AOSNFX-8224492")]
    [DisplayName("Response Recipient")]
    [IsoXmlTag("RspnRcpt")]
    public QualifiedPartyIdentification1? ResponseRecipient { get; init; }

    /// <summary>
    /// Party to receive a copy of the message.
    /// </summary>
    [IsoId("_OTgzMjE4-AOSNFX-8224492")]
    [DisplayName("Copy Recipient")]
    [IsoXmlTag("CpyRcpt")]
    public QualifiedPartyIdentification1? CopyRecipient { get; init; }

    /// <summary>
    /// Other party involved. This element is usable as a target for IDREFs.
    /// </summary>
    [IsoId("_OTgzMjE5-AOSNFX-8224492")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public QualifiedPartyIdentification1? OtherParty { get; init; }

    /// <summary>
    /// Associated free form document.
    /// </summary>
    [IsoId("_OTgzMjIw-AOSNFX-8224493")]
    [DisplayName("Associated Document")]
    [IsoXmlTag("AssoctdDoc")]
    public QualifiedDocumentInformation1? AssociatedDocument { get; init; }

    /// <summary>
    /// Governing contract.
    /// </summary>
    [IsoId("_OTgzMjIx-AOSNFX-8224493")]
    [DisplayName("Governing Contract")]
    [IsoXmlTag("GovngCtrct")]
    public QualifiedDocumentInformation1? GoverningContract { get; init; }

    /// <summary>
    /// Rules and laws governing the letter.
    /// </summary>
    [IsoId("_OTgzMjIz-AOSNFX-8224493")]
    [DisplayName("Legal Context")]
    [IsoXmlTag("LglCntxt")]
    public GovernanceRules2? LegalContext { get; init; }

    /// <summary>
    /// Free form information about this message.
    /// </summary>
    [IsoId("_OTgzMjI0-AOSNFX-8224493")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000, MinimumLength = 1)]
    public IsoMax2000Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Free form information unrelated to the message for example advertising or a service notice.
    /// </summary>
    [IsoId("_OTgzMjI1-AOSNFX-8224493")]
    [DisplayName("Notice")]
    [IsoXmlTag("Ntce")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Notice { get; init; }

    /// <summary>
    /// Status of referenced messages or letters.
    /// </summary>
    [IsoId("_OTgzMjI2-AOSNFX-8224493")]
    [DisplayName("Validation Status Information")]
    [IsoXmlTag("VldtnStsInf")]
    public ValidationStatusInformation1? ValidationStatusInformation { get; init; }

    /// <summary>
    /// Digital signatures and signing parties of this letter or parts of it.
    /// </summary>
    [IsoId("_OTgzMjI4-AOSNFX-8224493")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public QualifiedPartyAndXMLSignature1? DigitalSignature { get; init; }
}
