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



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.068.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. 
/// The message may also be forwarded to any authorised third party, as defined in the local scheme
/// </summary>
[Description(@"The RequestToPayCreditorEnrolmentCancellationRequest message is sent by the creditor RTP (Request To Pay) provider to an RTP directory provider and optionally by the creditor to a creditor RTP provider to request for the cancellation of the creditor registration in the RTP directory. |The message may also be forwarded to any authorised third party, as defined in the local scheme")]
[IsoId("_rNNBm-HzEeqbls7Gk4-ckA")]
[DisplayName("Request To Pay Creditor Enrolment Cancellation Request V")]
public partial record RequestToPayCreditorEnrolmentCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.068.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.068.001.01";
    
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
    /// Set of characteristics to identify the message and parties playing a role in the cancellation of the creditor enrolment.
    /// </summary>
    [IsoId("_rNNBn-HzEeqbls7Gk4-ckA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required EnrolmentHeader2 Header { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide details on the cancellation request.
    /// </summary>
    [IsoId("_rNNBoeHzEeqbls7Gk4-ckA")]
    [DisplayName("Cancellation Data")]
    [IsoXmlTag("CxlData")]
    public required CreditorEnrolmentCancellation2 CancellationData { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBo-HzEeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestToPayCreditorEnrolmentCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToPayCreditorEnrolmentCancellationRequestV01.

