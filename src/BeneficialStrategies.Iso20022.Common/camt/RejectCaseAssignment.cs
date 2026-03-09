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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectCaseAssignment instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectCaseAssignment( CaseAssignment reqAssignment,Case reqCase,CaseAssignmentRejectionJustification reqJustification )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Justification = reqJustification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment.
    /// </summary>
    [IsoId("_PxiCw9E_Ed-BzquC8wXy7w_2109597961")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment Assignment { get; init; } 
    #else
    public CaseAssignment Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_PxiCxNE_Ed-BzquC8wXy7w_2125297631")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Case Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case Case { get; init; } 
    #else
    public Case Case { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for not accepting a Case.
    /// </summary>
    [IsoId("_PxiCxdE_Ed-BzquC8wXy7w_-1282168665")]
    [DisplayName("Justification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Justfn")]
    #endif
    [IsoXmlTag("Justfn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignmentRejectionJustification Justification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignmentRejectionJustification Justification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignmentRejectionJustification Justification { get; init; } 
    #else
    public CaseAssignmentRejectionJustification Justification { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RejectCaseAssignmentDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RejectCaseAssignment.

