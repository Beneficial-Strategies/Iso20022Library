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
/// This record is an implementation of the camt.026.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Unable To Apply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.
/// Usage
/// The Unable To Apply case occurs in two situations:
/// - an agent cannot execute the payment instruction due to missing or incorrect information
/// - a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation
/// The Unable To Apply message
/// - always follows the reverse route of the original payment instruction
/// - must be forwarded to the preceding agents in the payment processing chain, where appropriate
/// - covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple Unable To Apply messages must be sent.
/// Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:
/// - Additional Payment Information message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation.
/// - Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW).
/// - Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW).
/// - Debit Authorisation Request message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.|The UnableToApply message has the following main characteristics:|- Case Identification and Reason Code:|The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally|the reason code for the Unable To Apply message. This information will be passed unchanged to all subsequent case|assignees.|- Underlying Payment Instruction Identification:|The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated|by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- Unable To Apply Justification:|The Unable To Apply Justification element allows the assigner to indicate whether a specific element causes the unable|to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information|needs to be forwarded.
/// </summary>
[Description(@"Scope|The Unable To Apply message is sent by a case creator or a case assigner to a case assignee. This message is used to initiate an investigation of a payment instruction that cannot be executed or reconciled.|Usage|The Unable To Apply case occurs in two situations:|- an agent cannot execute the payment instruction due to missing or incorrect information|- a creditor cannot reconcile the payment entry as it is received unexpectedly, or missing or incorrect information prevents reconciliation|The Unable To Apply message|- always follows the reverse route of the original payment instruction|- must be forwarded to the preceding agents in the payment processing chain, where appropriate|- covers one and only one payment instruction (or payment entry) at a time; if several payment instructions cannot be executed or several payment entries cannot be reconciled, then multiple Unable To Apply messages must be sent.|Depending on what stage the payment is and what has been done to it, for example incorrect routing, errors/omissions when processing the instruction or even the absence of any error, the unable to apply case may lead to a:|- Additional Payment Information message, sent to the case creator/case assigner, if a truncation or omission in a payment instruction prevented reconciliation.|- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents (this also entails a new corrected payment instruction being issued). Prior to sending the payment cancellation request, the agent should first send a resolution indicating that a cancellation will follow (CWFW).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction. Prior to sending the modify payment request, the agent should first send a resolution indicating that a modification will follow (MWFW).|- Debit Authorisation Request message, sent to the case creator/case assigner, if the payment instruction has reached an incorrect creditor.|The UnableToApply message has the following main characteristics:|- Case Identification and Reason Code:|The case creator (the instructed party/creditor of a payment instruction) assigns a unique case identification and optionally|the reason code for the Unable To Apply message. This information will be passed unchanged to all subsequent case|assignees.|- Underlying Payment Instruction Identification:|The case creator specifies the identification of the underlying payment instruction. This identification needs to be updated|by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- Unable To Apply Justification:|The Unable To Apply Justification element allows the assigner to indicate whether a specific element causes the unable|to apply situation (incorrect element and/or mismatched element can be listed) or whether any supplementary information|needs to be forwarded.")]
[IsoId("_hCmh-NE_Ed-BzquC8wXy7w_120677065")]
[DisplayName("Unable To Apply V")]
public partial record UnableToApplyV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.026.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UblToApply";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.03";
    
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
    [IsoId("_hCmh-dE_Ed-BzquC8wXy7w_1294030861")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment2 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_hCmh-tE_Ed-BzquC8wXy7w_1294030685")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case2 Case { get; init; } 
    
    /// <summary>
    /// References the payment instruction or statement entry that a party is unable to execute or unable to reconcile.
    /// </summary>
    [IsoId("_hCwS8NE_Ed-BzquC8wXy7w_1294030738")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingTransaction1Choice_ Underlying { get; init; } 
    
    /// <summary>
    /// Explains the reason why the case creator is unable to apply the instruction.
    /// </summary>
    [IsoId("_hCwS8dE_Ed-BzquC8wXy7w_120677127")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required UnableToApplyJustification2Choice_ Justification { get; init; } 
    
    
    #nullable disable
    
}


// Since UnableToApplyV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UnableToApplyV03.

