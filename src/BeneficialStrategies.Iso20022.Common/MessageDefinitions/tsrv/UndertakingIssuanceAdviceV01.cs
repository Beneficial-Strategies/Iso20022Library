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
/// This record is an implementation of the tsrv.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.
/// </summary>
[Description(@"The UndertakingIssuanceAdvice message is sent by an advising party to the beneficiary, either directly or via one or more other advising parties in the transaction chain, to advise the issuance of an undertaking. Other interested parties may also be informed of the advice. The undertaking advised could be a demand guarantee, standby letter of credit, or counter-undertaking (counter-guarantee or counter-standby). In addition to providing details on the applicable rules, expiry date, the amount, required documents, and terms and conditions of the undertaking, the advice may provide information from the sender such as confirmation details.")]
[IsoId("_9fkHg3ltEeG7BsjMvd1mEw_-135389308")]
[DisplayName("Undertaking Issuance Advice V")]
public partial record UndertakingIssuanceAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgIssncAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.002.001.01";
    
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
    [IsoId("_HtBI0z1UEeKvwJ48Wu13ug")]
    [DisplayName("Advising Party")]
    [IsoXmlTag("AdvsgPty")]
    public required PartyIdentification43 AdvisingParty { get; init; } 
    
    /// <summary>
    /// Additional party that advises the undertaking.
    /// </summary>
    [IsoId("_WPnPkz1UEeKvwJ48Wu13ug")]
    [DisplayName("Second Advising Party")]
    [IsoXmlTag("ScndAdvsgPty")]
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    
    /// <summary>
    /// Date on which the undertaking is advised.
    /// </summary>
    [IsoId("_bOgLdT1UEeKvwJ48Wu13ug")]
    [DisplayName("Date Of Advice")]
    [IsoXmlTag("DtOfAdvc")]
    public required DateAndDateTimeChoice_ DateOfAdvice { get; init; } 
    
    /// <summary>
    /// Details related to the advice of the issued undertaking.
    /// </summary>
    [IsoId("_9fkHhHltEeG7BsjMvd1mEw_-1882715655")]
    [DisplayName("Undertaking Issuance Advice Details")]
    [IsoXmlTag("UdrtkgIssncAdvcDtls")]
    public required UndertakingAdvice1 UndertakingIssuanceAdviceDetails { get; init; } 
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_pgGLlRWxEeKtPMeuz5Qhfw")]
    [DisplayName("Bank To Bank Information")]
    [IsoXmlTag("BkToBkInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> BankToBankInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Digital signature of the undertaking advice.
    /// </summary>
    [IsoId("_9fkHhXltEeG7BsjMvd1mEw_1405552400")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingIssuanceAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingIssuanceAdviceV01.

