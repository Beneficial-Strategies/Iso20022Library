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



namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.009.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForTransferStatusReport is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.
/// The RequestForTransferStatusReport may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to request information relevant for the settlement of a transfer transaction.
/// Usage
/// The RequestForTransferStatusReport is used to request either:
/// - the status of one or several information requests or transfer instructions or,
/// - the status of one or several transfer cancellation instructions, or
/// - information relevant to one or more transfer instructions.
/// </summary>
[Description(@"Scope|The RequestForTransferStatusReport is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.|The RequestForTransferStatusReport may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to request information relevant for the settlement of a transfer transaction.|Usage|The RequestForTransferStatusReport is used to request either:|- the status of one or several information requests or transfer instructions or,|- the status of one or several transfer cancellation instructions, or|- information relevant to one or more transfer instructions.")]
[IsoId("_Ix6uEdvdEeqxGfKJubfhIw")]
[DisplayName("Request For Transfer Status Report V")]
public partial record RequestForTransferStatusReportV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.009.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForTrfStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.08";
    
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
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Ix7VIdvdEeqxGfKJubfhIw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Information to identify the transfer for which the status is requested.
    /// </summary>
    [IsoId("_Ix7VI9vdEeqxGfKJubfhIw")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference13 RequestDetails { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_Ix7VJdvdEeqxGfKJubfhIw")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ix7VJ9vdEeqxGfKJubfhIw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForTransferStatusReportV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForTransferStatusReportV08.

