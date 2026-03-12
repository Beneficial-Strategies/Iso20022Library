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
/// This record is an implementation of the sese.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInstructionStatusReport message is sent by an instructing party to the executing party. The instructing party may be an investor, a transfer agent, or an intermediary, etc. The executing party may be a transfer agent, or an intermediary, etc.
/// This message gives the status of a transfer instruction, and can be used from the time the executing party receives the transfer instruction until its execution.
/// Usage
/// The TransferInstructionStatusReport message is sent by an executing party to the instructing party. The message can be used to report one of the following
/// - the status of the transfer instruction (using a code)or
/// - the repair status or
/// - the unmatched status or
/// - the rejection status or
/// - the pending settlement status.
/// Further information about repair, unmatched, rejected or pending settlement statuses must be specified using either codes or unstructured information.
/// </summary>
[Description(@"Scope|The TransferInstructionStatusReport message is sent by an instructing party to the executing party. The instructing party may be an investor, a transfer agent, or an intermediary, etc. The executing party may be a transfer agent, or an intermediary, etc.|This message gives the status of a transfer instruction, and can be used from the time the executing party receives the transfer instruction until its execution.|Usage|The TransferInstructionStatusReport message is sent by an executing party to the instructing party. The message can be used to report one of the following|- the status of the transfer instruction (using a code)or|- the repair status or|- the unmatched status or|- the rejection status or|- the pending settlement status.|Further information about repair, unmatched, rejected or pending settlement statuses must be specified using either codes or unstructured information.")]
[IsoId("_K0uj29E6Ed-BzquC8wXy7w_569643185")]
[DisplayName("Transfer Instruction Status Report")]
public partial record TransferInstructionStatusReport : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.011.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.01";
    
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K0uj3NE6Ed-BzquC8wXy7w_902110432")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference2 RelatedReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_K04U0NE6Ed-BzquC8wXy7w_900264708")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public required AdditionalReference2 OtherReference { get; init; } 
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_K04U0dE6Ed-BzquC8wXy7w_2104535600")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required TransferStatusAndReason StatusReport { get; init; } 
    
    
    #nullable disable
    
}


// Since TransferInstructionStatusReportDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInstructionStatusReport.

