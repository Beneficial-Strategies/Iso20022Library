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
/// This record is an implementation of the camt.031.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Reject Case Assignment message is sent by a case assignee to a case creator or case assigner to reject a case given to him.
/// Usage
/// The Reject Case Assignment message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// Rejecting a case assignment occurs when the case assignee is unable to trace the original payment instruction or when the case assignee is unable, or does not have authority, to process the assigned case.
/// The Reject Case Assignment message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple Reject Case Assignment messages must be sent.
/// The Reject Case Assignment message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner.
/// The Reject Case Assignment message must not be used in place of a Resolution Of Investigation or Case Status Report message.
/// </summary>
[Description(@"Scope|The Reject Case Assignment message is sent by a case assignee to a case creator or case assigner to reject a case given to him.|Usage|The Reject Case Assignment message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|Rejecting a case assignment occurs when the case assignee is unable to trace the original payment instruction or when the case assignee is unable, or does not have authority, to process the assigned case.|The Reject Case Assignment message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple Reject Case Assignment messages must be sent.|The Reject Case Assignment message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner.|The Reject Case Assignment message must not be used in place of a Resolution Of Investigation or Case Status Report message.")]
[IsoId("_PxiCwtE_Ed-BzquC8wXy7w_-313128527")]
[DisplayName("Reject Case Assignment")]
public partial record RejectCaseAssignment : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.031.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.031.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.031.001.01";
    
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
    /// Identifies the assignment.
    /// </summary>
    [IsoId("_PxiCw9E_Ed-BzquC8wXy7w_2109597961")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_PxiCxNE_Ed-BzquC8wXy7w_2125297631")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case Case { get; init; } 
    
    /// <summary>
    /// Specifies the reason for not accepting a Case.
    /// </summary>
    [IsoId("_PxiCxdE_Ed-BzquC8wXy7w_-1282168665")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required CaseAssignmentRejectionJustification Justification { get; init; } 
    
    
    #nullable disable
    
}


// Since RejectCaseAssignmentDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RejectCaseAssignment.

