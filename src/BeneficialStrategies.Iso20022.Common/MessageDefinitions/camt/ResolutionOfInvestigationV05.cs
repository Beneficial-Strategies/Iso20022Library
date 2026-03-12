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
/// This record is an implementation of the camt.029.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee
/// - information on the return where applicable
/// Usage
/// The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The Resolution Of Investigation message provides:
/// - the final outcome of the case, whether positive or negative
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The Resolution Of Investigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator
/// - not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message
/// Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.
/// The Resolution Of Investigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the Cancellation Details component.
/// </summary>
[Description(@"Scope|The Resolution Of Investigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee|- information on the return where applicable|Usage|The Resolution Of Investigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The Resolution Of Investigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The Resolution Of Investigation message provides:|- the final outcome of the case, whether positive or negative|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return|Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.|The Resolution Of Investigation message must:|- be forwarded by all subsequent case assignee(s) until it reaches the case creator|- not be used in place of a Reject Case Assignment or Case Status Report or Notification Of Case Assignment message|Take note of an exceptional rule that allows the use of Resolution Of Investigation in lieu of a Case Status Report. Case Status Report is a response-message to a Case Status Report Request. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the Request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a Case Status Report when then followed immediately by a Resolution Of Investigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the Resolution Of Investigation message directly.|The Resolution Of Investigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the Cancellation Details component.")]
[IsoId("_wQzazRPeEeSVo-TFVwFHvA")]
[DisplayName("Resolution Of Investigation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResolutionOfInvestigationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.029.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.05";
    
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
    /// Constructs a ResolutionOfInvestigationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResolutionOfInvestigationV05( CaseAssignment3 reqAssignment,InvestigationStatus3Choice_ reqStatus )
    {
        Assignment = reqAssignment;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_wQza2RPeEeSVo-TFVwFHvA")]
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
    /// Identifies a resolved case.
    /// </summary>
    [IsoId("_wQza2xPeEeSVo-TFVwFHvA")]
    [DisplayName("Resolved Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RslvdCase")]
    #endif
    [IsoXmlTag("RslvdCase")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case3? ResolvedCase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3? ResolvedCase { get; init; } 
    #else
    public Case3? ResolvedCase { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the status of the investigation.
    /// </summary>
    [IsoId("_wQza3RPeEeSVo-TFVwFHvA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationStatus3Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigationStatus3Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationStatus3Choice_ Status { get; init; } 
    #else
    public InvestigationStatus3Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details of the underlying transactions being cancelled.
    /// </summary>
    [IsoId("_wQza3xPeEeSVo-TFVwFHvA")]
    [DisplayName("Cancellation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlDtls")]
    #endif
    [IsoXmlTag("CxlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingTransaction9? CancellationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTransaction9? CancellationDetails { get; init; } 
    #else
    public UnderlyingTransaction9? CancellationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details on the underlying statement entry.
    /// </summary>
    [IsoId("_wQza4RPeEeSVo-TFVwFHvA")]
    [DisplayName("Statement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtls")]
    #endif
    [IsoXmlTag("StmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementResolutionEntry2? StatementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementResolutionEntry2? StatementDetails { get; init; } 
    #else
    public StatementResolutionEntry2? StatementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// References a transaction initiated to fix the case under investigation.
    /// </summary>
    [IsoId("_wQza4xPeEeSVo-TFVwFHvA")]
    [DisplayName("Correction Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrctnTx")]
    #endif
    [IsoXmlTag("CrrctnTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorrectiveTransaction1Choice_? CorrectionTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorrectiveTransaction1Choice_? CorrectionTransaction { get; init; } 
    #else
    public CorrectiveTransaction1Choice_? CorrectionTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of a return or a reversal initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_wQza5RPeEeSVo-TFVwFHvA")]
    [DisplayName("Resolution Related Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltnRltdInf")]
    #endif
    [IsoXmlTag("RsltnRltdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; } 
    #else
    public ResolutionInformation1? ResolutionRelatedInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wQza5xPeEeSVo-TFVwFHvA")]
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


// Since ResolutionOfInvestigationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ResolutionOfInvestigationV05.

