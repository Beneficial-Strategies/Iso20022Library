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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.031.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Reject Investigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.
/// Usage
/// The Reject Investigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// Rejecting a case assignment occurs when:
/// - the case assignee is unable to trace the original payment instruction
/// - the case assignee is unable, or does not have authority, to process the assigned case (indicate &quot;You have by-passed a party&quot;,
/// - the case assignee has received a non expected message, and rejects the message with a wrong message indicator
/// - the case assignee has not yet received the Resolution Of Investigation message and the case has already been reopened
/// - the case assignee has rejects an non-cash related query
/// The Reject Investigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple Reject Investigation messages must be sent.
/// The Reject Investigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a Resolution Of Investigation or Case Status Report message.
/// </summary>
[Description(@"Scope|The Reject Investigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.|Usage|The Reject Investigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|Rejecting a case assignment occurs when:|- the case assignee is unable to trace the original payment instruction|- the case assignee is unable, or does not have authority, to process the assigned case (indicate ""You have by-passed a party"",|- the case assignee has received a non expected message, and rejects the message with a wrong message indicator|- the case assignee has not yet received the Resolution Of Investigation message and the case has already been reopened|- the case assignee has rejects an non-cash related query|The Reject Investigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple Reject Investigation messages must be sent.|The Reject Investigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a Resolution Of Investigation or Case Status Report message.")]
[IsoId("_sReoIlkyEeGeoaLUQk__nA_152798940")]
[DisplayName("Reject Investigation V")]
public partial record RejectInvestigationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.031.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RjctInvstgtn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.031.001.04";
    
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
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_sReoI1kyEeGeoaLUQk__nA_186122745")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment3 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_sReoJFkyEeGeoaLUQk__nA_-697110542")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case3 Case { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the rejection of an investigation.
    /// </summary>
    [IsoId("_sReoJVkyEeGeoaLUQk__nA_-810949608")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required InvestigationRejectionJustification1 Justification { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sRoZIFkyEeGeoaLUQk__nA_-295840138")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since RejectInvestigationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RejectInvestigationV04.

