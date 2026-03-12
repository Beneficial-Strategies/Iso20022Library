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
/// This record is an implementation of the tsrv.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ExtendOrPayRequest message is sent by the party that issued the undertaking to the party that requested issuance of the undertaking (applicant or obligor), to request the applicant&apos;s response to a beneficiary request to extend or pay.
/// </summary>
[Description(@"The ExtendOrPayRequest message is sent by the party that issued the undertaking to the party that requested issuance of the undertaking (applicant or obligor), to request the applicant's response to a beneficiary request to extend or pay.")]
[IsoId("_9hNGQnltEeG7BsjMvd1mEw_-1297539311")]
[DisplayName("Extend Or Pay Request V")]
public partial record ExtendOrPayRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "XtndOrPayReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.014.001.01";
    
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
    /// Details of the extend or pay request.
    /// </summary>
    [IsoId("_9hNGQ3ltEeG7BsjMvd1mEw_-740598928")]
    [DisplayName("Extend Or Pay Request Details")]
    [IsoXmlTag("XtndOrPayReqDtls")]
    public required ExtendOrPayQuery1 ExtendOrPayRequestDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the request.
    /// </summary>
    [IsoId("_9hNGRHltEeG7BsjMvd1mEw_1034955414")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since ExtendOrPayRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ExtendOrPayRequestV01.

