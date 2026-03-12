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
/// This record is an implementation of the camt.032.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Cancel Case Assignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.
/// Usage
/// The Cancel Case Assignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a Claim Non Receipt message).
/// The Cancel Case Assignment message can be used to stop the processing of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Cancel Case Assignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple Cancel Case Assignment messages must be sent.
/// The Cancel Case Assignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.
/// When an agent re-assigns the Cancel Case Assignment to a subsequent case assignee, this agent must send a Notification Of Case Assignment message to its assigner.
/// When the Cancel Case Assignment instruction has been acted upon by the relevant case assignee, a Resolution Of Investigation message is sent to the case assigner or case creator, in reply.
/// The Cancel Case Assignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a Request To Cancel Payment message must be used, with the case identification of the original Request To Modify Payment message. In this context it is incorrect to use the Cancel Case Assignment message.
/// </summary>
[Description(@"Scope|The Cancel Case Assignment message is sent by a case creator or case assigner to a case assignee. This message is used to request the cancellation of a case.|Usage|The Cancel Case Assignment message is used to stop the processing of a case at a case assignee when a case assignment is incorrect or when the root cause for the case disappears (such as the account owner was able to reconcile after sending a Claim Non Receipt message).|The Cancel Case Assignment message can be used to stop the processing of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Cancel Case Assignment message covers one and only one case at a time. If several case assignments need to be cancelled, then multiple Cancel Case Assignment messages must be sent.|The Cancel Case Assignment message must be forwarded by all subsequent case assignee(s) in the case processing chain until it reaches the end point.|When an agent re-assigns the Cancel Case Assignment to a subsequent case assignee, this agent must send a Notification Of Case Assignment message to its assigner.|When the Cancel Case Assignment instruction has been acted upon by the relevant case assignee, a Resolution Of Investigation message is sent to the case assigner or case creator, in reply.|The Cancel Case Assignment message must not be used for other purposes. If, for example, a request to modify payment fails, and the case creator requests the cancellation of the payment, then a Request To Cancel Payment message must be used, with the case identification of the original Request To Modify Payment message. In this context it is incorrect to use the Cancel Case Assignment message.")]
[IsoId("_L_DsKNE-Ed-BzquC8wXy7w_-767166223")]
[DisplayName("Cancel Case Assignment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelCaseAssignment : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.032.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.032.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.032.001.01";
    
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
    /// Constructs a CancelCaseAssignment instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelCaseAssignment( CaseAssignment reqAssignment,Case reqCase )
    {
        Assignment = reqAssignment;
        Case = reqCase;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment.
    /// </summary>
    [IsoId("_L_NdINE-Ed-BzquC8wXy7w_2010781647")]
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
    [IsoId("_L_NdIdE-Ed-BzquC8wXy7w_450552846")]
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
    
    
    #nullable disable
    
}


// Since CancelCaseAssignmentDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelCaseAssignment.

