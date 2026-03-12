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
/// This record is an implementation of the reda.069.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RequestToPayCreditorEnrolmentStatusReport message is sent from the RTP (Request To Pay) directory provider to the creditor RTP provider and optionally from the creditor RTP provider to the creditor or any of the forwarding agent to provide the status of the initial creation, amendment or cancellation request.
/// </summary>
[Description(@"The RequestToPayCreditorEnrolmentStatusReport message is sent from the RTP (Request To Pay) directory provider to the creditor RTP provider and optionally from the creditor RTP provider to the creditor or any of the forwarding agent to provide the status of the initial creation, amendment or cancellation request.")]
[IsoId("_rNNBr-HzEeqbls7Gk4-ckA")]
[DisplayName("Request To Pay Creditor Enrolment Status Report V")]
public partial record RequestToPayCreditorEnrolmentStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.069.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToPayCdtrEnrlmntStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.069.001.01";
    
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
    /// Set of characteristics to identify the message and parties playing a role in the status report of the creditor enrolment.
    /// </summary>
    [IsoId("_rNNBs-HzEeqbls7Gk4-ckA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required EnrolmentHeader2 Header { get; init; } 
    
    /// <summary>
    /// Status of the creditor enrolment instruction (that is request, amendment or cancellation).
    /// </summary>
    [IsoId("_rNNBteHzEeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment And Status")]
    [IsoXmlTag("OrgnlEnrlmntAndSts")]
    public required EnrolmentStatus2 OriginalEnrolmentAndStatus { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rNNBt-HzEeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestToPayCreditorEnrolmentStatusReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToPayCreditorEnrolmentStatusReportV01.

