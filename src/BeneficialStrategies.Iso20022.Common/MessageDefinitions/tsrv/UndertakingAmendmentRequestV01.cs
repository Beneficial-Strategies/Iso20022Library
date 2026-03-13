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
/// This record is an implementation of the tsrv.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking to request issuance of a proposed amendment to the undertaking. The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. The message provides details on proposed changes to the undertaking, for example, to the expiry date, amount, and/or terms and conditions. It may also be used to request termination or cancellation of the undertaking.
/// </summary>
[Description(@"The UndertakingAmendmentRequest message is sent by the party that requested issuance of the undertaking (applicant or obligor) to the party that issued the undertaking to request issuance of a proposed amendment to the undertaking. The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. The message provides details on proposed changes to the undertaking, for example, to the expiry date, amount, and/or terms and conditions. It may also be used to request termination or cancellation of the undertaking.")]
[IsoId("_9f3CdnltEeG7BsjMvd1mEw_-206674723")]
[DisplayName("Undertaking Amendment Request V")]
public partial record UndertakingAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.004.001.01";
    
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
    /// Details related to the request for an amendment of an undertaking.
    /// </summary>
    [IsoId("_9f3Cd3ltEeG7BsjMvd1mEw_-1387733041")]
    [DisplayName("Undertaking Amendment Request Details")]
    [IsoXmlTag("UdrtkgAmdmntReqDtls")]
    public required Amendment3 UndertakingAmendmentRequestDetails { get; init; } 
    
    /// <summary>
    /// Instructions specific to the bank receiving the message.
    /// </summary>
    [IsoId("_MZwWVX_6EeGOn4dfTT_QdQ")]
    [DisplayName("Instructions To Bank")]
    [IsoXmlTag("InstrsToBk")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> InstructionsToBank { get; init; } = [];
    
    /// <summary>
    /// Digital signature of the undertaking amendment request.
    /// </summary>
    [IsoId("_9f3CeHltEeG7BsjMvd1mEw_-2129123977")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingAmendmentRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentRequestV01.

