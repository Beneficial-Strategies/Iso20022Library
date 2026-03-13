// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the content of a proposed amendment to an undertaking. Information about the message may also be sent to other interested parties. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing the terms of the proposed amendment and relevant details on proposed changes to the undertaking, the message may provide information from the sender such as confirmation details. It may also be used to advise the proposed termination or cancellation of the undertaking.
/// </summary>
[Description(@"The UndertakingAmendmentAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the content of a proposed amendment to an undertaking. Information about the message may also be sent to other interested parties. The proposed undertaking amendment could be to a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing the terms of the proposed amendment and relevant details on proposed changes to the undertaking, the message may provide information from the sender such as confirmation details. It may also be used to advise the proposed termination or cancellation of the undertaking.")]
[IsoId("_9gJ9ZnltEeG7BsjMvd1mEw_1371399250")]
[DisplayName("Undertaking Amendment Advice V")]
public partial record UndertakingAmendmentAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Party advising the undertaking to the beneficiary or to another party.
    /// </summary>
    [IsoId("_pUXylT1XEeKWjKfYlNE7jQ")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public required PartyIdentification43 AdvisingParty { get; init; } 
    
    /// <summary>
    /// Additional party that advises the undertaking.
    /// </summary>
    [IsoId("_rsgupT1XEeKWjKfYlNE7jQ")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    
    /// <summary>
    /// Date on which the undertaking is advised.
    /// </summary>
    [IsoId("_uNTQYz1XEeKWjKfYlNE7jQ")]
    [DisplayName("Date Of Advice")]
    [IsoXmlTag("DtOfAdvc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfAdvice { get; init; } 
    
    /// <summary>
    /// Details related to the advice of the proposed amended undertaking.
    /// </summary>
    [IsoId("_9gJ9Z3ltEeG7BsjMvd1mEw_315692948")]
    [DisplayName("Undertaking Amendment Advice Details")]
    [IsoXmlTag("UdrtkgAmdmntAdvcDtls")]
    public required Amendment2 UndertakingAmendmentAdviceDetails { get; init; } 
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_EUVqJxWyEeKtPMeuz5Qhfw")]
    [DisplayName("Bank To Bank Information")]
    [IsoXmlTag("BkToBkInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> BankToBankInformation { get; init; } = [];
    
    /// <summary>
    /// Digital signature of the proposed amendment advice.
    /// </summary>
    [IsoId("_9gJ9aHltEeG7BsjMvd1mEw_1348230221")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingAmendmentAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentAdviceV01.

