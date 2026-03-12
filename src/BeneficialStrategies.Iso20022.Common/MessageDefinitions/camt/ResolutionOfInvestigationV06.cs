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
/// This record is an implementation of the camt.029.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.
/// This message is used to inform of the resolution of a case, and optionally provides details about.
/// - the corrective action undertaken by the case assignee
/// - information on the return where applicable
/// Usage
/// The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:
/// - request to cancel payment case
/// - request to modify payment case
/// - unable to apply case
/// - claim non receipt case
/// The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.
/// The ResolutionOfInvestigation message provides:
/// - the final outcome of the case, whether positive or negative
/// - optionally, the details of the corrective action undertaken by the case assignee and the information of the return
/// Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.
/// Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.
/// The ResolutionOfInvestigation message must:
/// - be forwarded by all subsequent case assignee(s) until it reaches the case creator
/// - not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message
/// Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.
/// The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.
/// </summary>
[Description(@"Scope|The ResolutionOfInvestigation message is sent by a case assignee to a case creator/case assigner.|This message is used to inform of the resolution of a case, and optionally provides details about.|- the corrective action undertaken by the case assignee|- information on the return where applicable|Usage|The ResolutionOfInvestigation message is used by the case assignee to inform a case creator or case assigner about the resolution of a:|- request to cancel payment case|- request to modify payment case|- unable to apply case|- claim non receipt case|The ResolutionOfInvestigation message covers one and only one case at a time. If the case assignee needs to communicate about several cases, then several Resolution Of Investigation messages must be sent.|The ResolutionOfInvestigation message provides:|- the final outcome of the case, whether positive or negative|- optionally, the details of the corrective action undertaken by the case assignee and the information of the return|Whenever a payment instruction has been generated to solve the case under investigation following a claim non receipt or an unable to apply, the optional CorrectionTransaction component present in the message must be completed.|Whenever the action of modifying or cancelling a payment results in funds being returned or reversed, an investigating agent may provide the details in the resolution related investigation component, to identify the return or reversal transaction. These details will facilitate the account reconciliations at the initiating bank and the intermediaries. It must be stressed that the return or reversal of funds is outside the scope of this Exceptions and Investigation service. The features given here is only meant to transmit the information of return or reversal when it is available through the resolution of the case.|The ResolutionOfInvestigation message must:|- be forwarded by all subsequent case assignee(s) until it reaches the case creator|- not be used in place of a RejectCaseAssignment or CaseStatusReport or NotificationOfCaseAssignment message|Take note of an exceptional rule that allows the use of ResolutionOfInvestigation in lieu of a CaseStatusReport. CaseStatusReport is a response-message to a CaseStatusReportRequest. The latter which is sent when the assigner has reached its own time-out threshold to receive a response. However it may happen that when the request arrives, the investigating agent has just obtained a resolution. In such a situation, it would be redundant to send a CaseStatusReport when then followed immediately by a ResolutionOfInvestigation. It is therefore quite acceptable for the investigating agent, the assignee, to skip the Case Status Report and send the ResolutionOfInvestigation message directly.|The ResolutionOfInvestigation message should be the sole message to respond to a cancellation request. Details of the underlying transactions and the related statuses for which the cancellation request has been issued may be provided in the CancellationDetails component.")]
[IsoId("_pmmdwzqxEeWZFYSPlduMhw")]
[DisplayName("Resolution Of Investigation V")]
public partial record ResolutionOfInvestigationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.029.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsltnOfInvstgtn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.029.001.06";
    
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
    [IsoId("_pmmdzzqxEeWZFYSPlduMhw")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment3 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies a resolved case.
    /// </summary>
    [IsoId("_pmmd0TqxEeWZFYSPlduMhw")]
    [DisplayName("Resolved Case")]
    [IsoXmlTag("RslvdCase")]
    public Case3? ResolvedCase { get; init; } 
    
    /// <summary>
    /// Indicates the status of the investigation.
    /// </summary>
    [IsoId("_pmmd0zqxEeWZFYSPlduMhw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required InvestigationStatus3Choice_ Status { get; init; } 
    
    /// <summary>
    /// Specifies the details of the underlying transactions being cancelled.
    /// </summary>
    [IsoId("_pmmd1TqxEeWZFYSPlduMhw")]
    [DisplayName("Cancellation Details")]
    [IsoXmlTag("CxlDtls")]
    public UnderlyingTransaction14? CancellationDetails { get; init; } 
    
    /// <summary>
    /// Details on the underlying statement entry.
    /// </summary>
    [IsoId("_pmmd1zqxEeWZFYSPlduMhw")]
    [DisplayName("Statement Details")]
    [IsoXmlTag("StmtDtls")]
    public StatementResolutionEntry2? StatementDetails { get; init; } 
    
    /// <summary>
    /// References a transaction initiated to fix the case under investigation.
    /// </summary>
    [IsoId("_pmmd2TqxEeWZFYSPlduMhw")]
    [DisplayName("Correction Transaction")]
    [IsoXmlTag("CrrctnTx")]
    public CorrectiveTransaction1Choice_? CorrectionTransaction { get; init; } 
    
    /// <summary>
    /// Reference of a return or a reversal initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    [IsoId("_pmmd2zqxEeWZFYSPlduMhw")]
    [DisplayName("Resolution Related Information")]
    [IsoXmlTag("RsltnRltdInf")]
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pmmd3TqxEeWZFYSPlduMhw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ResolutionOfInvestigationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ResolutionOfInvestigationV06.

