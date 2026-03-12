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
/// This record is an implementation of the sese.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForTransferStatusReport is sent by an instructing party to the executing party.
/// This message requests the status of a transfer instruction or the status of a transfer cancellation instruction.
/// Usage
/// The RequestForTransferStatusReport is sent by an instructing party to the executing party to request
/// - the status of one or several transfer instructions or
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Description(@"Scope|The RequestForTransferStatusReport is sent by an instructing party to the executing party.|This message requests the status of a transfer instruction or the status of a transfer cancellation instruction.|Usage|The RequestForTransferStatusReport is sent by an instructing party to the executing party to request|- the status of one or several transfer instructions or|- the status of one or several transfer cancellation instructions.")]
[IsoId("_nnEjSNE5Ed-BzquC8wXy7w_-788060154")]
[DisplayName("Request For Transfer Status Report")]
public partial record RequestForTransferStatusReport : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.009.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.01";
    
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
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("_nnEjSdE5Ed-BzquC8wXy7w_-359483453")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference1 RequestDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForTransferStatusReportDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForTransferStatusReport.

