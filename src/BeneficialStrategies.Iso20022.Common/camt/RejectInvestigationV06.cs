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
/// This record is an implementation of the camt.031.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RejectInvestigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.
/// Usage
/// The RejectInvestigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// Rejecting a case assignment occurs when:
/// - the case assignee is unable to trace the original payment instruction;
/// - the case assignee is unable, or does not have authority, to process the assigned case (indicate &quot;You have by-passed a party&quot;;
/// - the case assignee has received a non expected message, and rejects the message with a wrong message indicator;
/// - the case assignee has not yet received the ResolutionOfInvestigation message and the case has already been reopened;
/// - the case assignee has rejects an non-cash related query.
/// The RejectInvestigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple RejectInvestigation messages must be sent.
/// The RejectInvestigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a ResolutionOfInvestigation or CaseStatusReport message.
/// </summary>
[Description(@"Scope|The RejectInvestigation message is sent by a case assignee to a case creator or case assigner to reject a case given to him.|Usage|The RejectInvestigation message is used to notify the case creator or case assigner the rejection of an assignment by the case assignee in a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|Rejecting a case assignment occurs when:|- the case assignee is unable to trace the original payment instruction;|- the case assignee is unable, or does not have authority, to process the assigned case (indicate ""You have by-passed a party"";|- the case assignee has received a non expected message, and rejects the message with a wrong message indicator;|- the case assignee has not yet received the ResolutionOfInvestigation message and the case has already been reopened;|- the case assignee has rejects an non-cash related query.|The RejectInvestigation message covers one and only one case at a time. If the case assignee needs to reject several case assignments, then multiple RejectInvestigation messages must be sent.|The RejectInvestigation message must be forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not be used in place of a ResolutionOfInvestigation or CaseStatusReport message.")]
[IsoId("_eX_Ok22PEei3KuUgpx7Xcw")]
[DisplayName("Reject Investigation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectInvestigationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.031.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RjctInvstgtn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.031.001.06";
    
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
    /// Constructs a RejectInvestigationV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectInvestigationV06( CaseAssignment5 reqAssignment,InvestigationRejectionJustification1 reqJustification )
    {
        Assignment = reqAssignment;
        Justification = reqJustification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_OlW2PEei3KuUgpx7Xcw")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment5 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment5 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment5 Assignment { get; init; } 
    #else
    public CaseAssignment5 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_Ol22PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case5? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case5? Case { get; init; } 
    #else
    public Case5? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the rejection of an investigation.
    /// </summary>
    [IsoId("_eX_OmW2PEei3KuUgpx7Xcw")]
    [DisplayName("Justification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Justfn")]
    #endif
    [IsoXmlTag("Justfn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationRejectionJustification1 Justification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigationRejectionJustification1 Justification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationRejectionJustification1 Justification { get; init; } 
    #else
    public InvestigationRejectionJustification1 Justification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Om22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RejectInvestigationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RejectInvestigationV06.

