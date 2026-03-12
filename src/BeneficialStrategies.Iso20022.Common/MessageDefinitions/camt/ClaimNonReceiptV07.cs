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
/// This record is an implementation of the camt.027.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ClaimNonReceipt message is sent by a case creator/case assigner to a case assignee.
/// This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).
/// Usage
/// The claim non receipt case occurs in two situations: 
/// - The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a ClaimNonReceipt message to its account servicing institution is not retained;
/// - An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a ClaimNonReceipt message to the sender of the original payment instruction.
/// The ClaimNonReceipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple ClaimNonReceipt messages must be sent.
/// Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: 
/// - CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued);
/// - RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.
/// If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a ResolutionOfInvestigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on ResolutionOfInvestigation for more details).
/// In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a ResolutionOfInvestigation message with the CorrectionTransaction element mentioning the references of the cover payment.
/// The ClaimNonReceipt message may be forwarded to subsequent case assignees.
/// The ClaimNonReceipt message has the following main characteristics: 
/// - Case identification: The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s);
/// - Underlying payment: The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s);
/// - Missing cover indicator: The MissingCoverIndicator element distinguishes between a missing cover situation (when set to YES - true) or a missing funds situation (when set to NO - false);
/// - CoverCorrection: The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.
/// </summary>
[Description(@"Scope|The ClaimNonReceipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a ClaimNonReceipt message to its account servicing institution is not retained;|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a ClaimNonReceipt message to the sender of the original payment instruction.|The ClaimNonReceipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple ClaimNonReceipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued);|- RequestToModifyPayment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a ResolutionOfInvestigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on ResolutionOfInvestigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a ResolutionOfInvestigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The ClaimNonReceipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case identification: The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s);|- Underlying payment: The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s);|- Missing cover indicator: The MissingCoverIndicator element distinguishes between a missing cover situation (when set to YES - true) or a missing funds situation (when set to NO - false);|- CoverCorrection: The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.")]
[IsoId("_eX_OQ22PEei3KuUgpx7Xcw")]
[DisplayName("Claim Non Receipt V")]
public partial record ClaimNonReceiptV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.027.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ClmNonRct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.07";
    
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
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_OT22PEei3KuUgpx7Xcw")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment5 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OUW2PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case5? Case { get; init; } 
    
    /// <summary>
    /// Identifies the payment instruction for which the Creditor has not received the funds.|Usage: In case of a missing cover, it must be the identification of the related payment instruction.|In case of a claim non receipt initiated by the debtor, it must be the identification of the instruction.
    /// </summary>
    [IsoId("_eX_OU22PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingTransaction5Choice_ Underlying { get; init; } 
    
    /// <summary>
    /// Provides the cover related information of a claim non receipt investigation. The absence of the cover details means that the message is not a cover related investigation.
    /// </summary>
    [IsoId("_eX_OVW2PEei3KuUgpx7Xcw")]
    [DisplayName("Cover Details")]
    [IsoXmlTag("CoverDtls")]
    public MissingCover4? CoverDetails { get; init; } 
    
    /// <summary>
    /// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
    /// </summary>
    [IsoId("_eX_OV22PEei3KuUgpx7Xcw")]
    [DisplayName("Instruction For Assignee")]
    [IsoXmlTag("InstrForAssgne")]
    public InstructionForAssignee1? InstructionForAssignee { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_OWW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ClaimNonReceiptV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ClaimNonReceiptV07.

