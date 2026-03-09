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
/// This record is an implementation of the camt.030.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Notification Of Case Assignment message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform the case assigner that:
/// - the assignee is reassigning the case to the next agent in the transaction processing chain for further action
/// - the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point
/// Usage
/// The Notification Of Case Assignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Notification Of Case Assignment message
/// - covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent
/// - except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator
/// - must not be used in place of a Resolution Of Investigation or a Case Status Report message
/// When the assignee does not reassign the case to another party (that is responding with a Notification Of Case Assignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query.
/// </summary>
[Description(@"Scope|The Notification Of Case Assignment message is sent by a case assignee to a case creator/case assigner.|This message is used to inform the case assigner that:|- the assignee is reassigning the case to the next agent in the transaction processing chain for further action|- the assignee will work on the case himself, without re-assigning it to another party, and therefore indicating that the re-assignment has reached its end-point|Usage|The Notification Of Case Assignment message is used to notify the case creator or case assigner of further action undertaken by the case assignee in a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Notification Of Case Assignment message|- covers one and only one case at a time. If the case assignee needs to inform a case creator or case assigner about several cases, then multiple Notification Of Case Assignment messages must be sent|- except in the case where it is used to indicate that an agent is doing the correction himself, this message must be forwarded by all subsequent case assigner(s) until it reaches the case creator|- must not be used in place of a Resolution Of Investigation or a Case Status Report message|When the assignee does not reassign the case to another party (that is responding with a Notification Of Case Assignment message with notification MINE - The case is processed by the assignee), the case assignment should contain the case assignment elements as received in the original query.")]
[IsoId("_sYfPEVkyEeGeoaLUQk__nA_241653460")]
[DisplayName("Notification Of Case Assignment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotificationOfCaseAssignmentV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.030.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnOfCaseAssgnmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.030.001.04";
    
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
    /// Constructs a NotificationOfCaseAssignmentV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotificationOfCaseAssignmentV04( ReportHeader4 reqHeader,Case3 reqCase,CaseAssignment3 reqAssignment,CaseForwardingNotification3 reqNotification )
    {
        Header = reqHeader;
        Case = reqCase;
        Assignment = reqAssignment;
        Notification = reqNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies generic information about the notification.|The receiver of a notification must be the party which assigned the case to the sender.
    /// </summary>
    [IsoId("_sYoZAFkyEeGeoaLUQk__nA_-1955767076")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportHeader4 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportHeader4 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportHeader4 Header { get; init; } 
    #else
    public ReportHeader4 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_sYoZAVkyEeGeoaLUQk__nA_1455966933")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case3 Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Case3 Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3 Case { get; init; } 
    #else
    public Case3 Case { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_sYoZAlkyEeGeoaLUQk__nA_1342127867")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignment3 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseAssignment3 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignment3 Assignment { get; init; } 
    #else
    public CaseAssignment3 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the type of action taken.
    /// </summary>
    [IsoId("_sYyKAFkyEeGeoaLUQk__nA_458894580")]
    [DisplayName("Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntfctn")]
    #endif
    [IsoXmlTag("Ntfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseForwardingNotification3 Notification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseForwardingNotification3 Notification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseForwardingNotification3 Notification { get; init; } 
    #else
    public CaseForwardingNotification3 Notification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sYyKAVkyEeGeoaLUQk__nA_-135424207")]
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


// Since NotificationOfCaseAssignmentV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationOfCaseAssignmentV04.

