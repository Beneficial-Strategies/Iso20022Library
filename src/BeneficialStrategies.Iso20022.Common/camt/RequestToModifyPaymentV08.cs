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
/// This record is an implementation of the camt.087.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestToModifyPayment message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the modification of characteristics of an original payment instruction.
/// Usage
/// The RequestToModifyPayment message must be answered with a:
/// - ResolutionOfInvestigation message with a positive final outcome when the case assignee can perform the requested modification;
/// - ResolutionOfInvestigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified);
/// - RejectCaseAssignment message when the case assignee is unable or not authorised to perform the requested modification;
/// - NotificationOfCaseAssignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// The RequestToModifyPayment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple RequestToModifyPayment messages must be sent.
/// The RequestToModifyPayment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.
/// The RequestToModifyPayment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative ResolutionOfInvestigation message. (See section on ResolutionOfInvestigation for more details).
/// The RequestToModifyPayment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message to cancel it and issue and a new payment instruction.
/// The RequestToModifyPayment message may be forwarded to subsequent case assignee(s).
/// When a RequestToModifyPayment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the ResolutionOfInvestigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.
/// The RequestToModifyPayment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:
/// - Cancel the first payment using a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message and make a new payment with a higher and correct amount;
/// - Simply send a second payment with the supplementary amount.
/// Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:
/// - an AdditionalPaymentInformation message sent to the creditor of the original payment instruction;
/// - a DebitAuthorisationRequest message sent to the creditor of the original payment instruction;
/// - a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message sent to a subsequent case assignee.
/// The RequestToModifyPayment message can be sent to correct characteristics of an original payment instruction following receipt of an UnableToApply message. In this scenario, the case identification will remain the same.
/// The RequestToModifyPayment message has the following main characteristics:
/// The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).
/// Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.
/// The modification of the agent&apos;s or agents&apos; information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, that is the cover is executed through the agent(s) mentioned in the RequestToModifyPayment message. The cover payment must not be modified separately.
/// The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.
/// The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a NotificationOfCaseAssignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative ResolutionOfInvestigation message).
/// </summary>
[Description(@"Scope|The RequestToModifyPayment message is sent by a case creator/case assigner to a case assignee.|This message is used to request the modification of characteristics of an original payment instruction.|Usage|The RequestToModifyPayment message must be answered with a:|- ResolutionOfInvestigation message with a positive final outcome when the case assignee can perform the requested modification;|- ResolutionOfInvestigation message with a negative final outcome when the case assignee may perform the requested modification but fails to do so (too late, irrevocable instruction, one requested element cannot be modified);|- RejectCaseAssignment message when the case assignee is unable or not authorised to perform the requested modification;|- NotificationOfCaseAssignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|The RequestToModifyPayment message covers one and only one original instruction at a time. If several original payment instructions need to be modified, then multiple RequestToModifyPayment messages must be sent.|The RequestToModifyPayment message can be sent to request the modification of one or several elements of the original payment instruction. If many elements need to be modified, it is recommended to cancel the original payment instruction and initiate a new one.|The RequestToModifyPayment must be processed on an all or nothing basis. If one of the elements to be modified cannot be altered, the assignment must be rejected in full by means of a negative ResolutionOfInvestigation message. (See section on ResolutionOfInvestigation for more details).|The RequestToModifyPayment message must never be sent to request the modification of the currency of the original payment instruction. If the currency is wrong, use a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message to cancel it and issue and a new payment instruction.|The RequestToModifyPayment message may be forwarded to subsequent case assignee(s).|When a RequestToModifyPayment message is used to decrease the amount of the original payment instruction, the modification will trigger a return of funds from the case assignee to the case creator. The assignee may indicate, within the ResolutionOfInvestigation message, the amount to be returned, the date it is or will be returned and the channel through which the return will be done.|The RequestToModifyPayment message must never be sent to request the increase of the amount of the original payment instruction. To increase the amount in a payment, the debtor can do one of the following:|- Cancel the first payment using a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message and make a new payment with a higher and correct amount;|- Simply send a second payment with the supplementary amount.|Depending on the requested modification(s) and the processing stage of the original payment instruction, the processing of a request to modify payment case may end with one of the following:|- an AdditionalPaymentInformation message sent to the creditor of the original payment instruction;|- a DebitAuthorisationRequest message sent to the creditor of the original payment instruction;|- a CustomerPaymentCancellationRequest or a FIToFIPaymentCancellationRequest message sent to a subsequent case assignee.|The RequestToModifyPayment message can be sent to correct characteristics of an original payment instruction following receipt of an UnableToApply message. In this scenario, the case identification will remain the same.|The RequestToModifyPayment message has the following main characteristics:|The case creator assigns a unique case identification. This information will be passed unchanged to all subsequent case assignee(s).|Lowering the amount of an original payment instruction for which cover is provided by a separate instruction will systematically mean the modification of the whole transaction, including the cover. The case assignee performing the amount modification must initiate the return of funds in excess to the case creator.|The modification of the agent's or agents' information on an original payment instruction for which cover is provided by a separate instruction will systematically mean the whole transaction is modified, that is the cover is executed through the agent(s) mentioned in the RequestToModifyPayment message. The cover payment must not be modified separately.|The modification of a payment instruction can be initiated by either the debtor or any subsequent agent in the payment processing chain.|The case creator provides the information to be modified in line with agreements made with the case assignee. If the case assignee needs in turn to assign the case to a subsequent case assignee, the requested modification(s) must be in line with the agreement made with the next case assignee and a NotificationOfCaseAssignment message must be sent to the case assigner. Otherwise, the request to modify payment case must be rejected (by means of a negative ResolutionOfInvestigation message).")]
[IsoId("_IBkAj9cBEeq_l4BJLVUF2Q")]
[DisplayName("Request To Modify Payment V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestToModifyPaymentV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.087.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqToModfyPmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.087.001.08";
    
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
    /// Constructs a RequestToModifyPaymentV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestToModifyPaymentV08( CaseAssignment5 reqAssignment,UnderlyingTransaction7Choice_ reqUnderlying,RequestedModification10 reqModification )
    {
        Assignment = reqAssignment;
        Underlying = reqUnderlying;
        Modification = reqModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_IBkAl9cBEeq_l4BJLVUF2Q")]
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
    [IsoId("_IBkAmdcBEeq_l4BJLVUF2Q")]
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
    /// Identifies the payment transaction to be modified.
    /// </summary>
    [IsoId("_IBkAm9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingTransaction7Choice_ Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingTransaction7Choice_ Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTransaction7Choice_ Underlying { get; init; } 
    #else
    public UnderlyingTransaction7Choice_ Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the list of modifications requested.
    /// </summary>
    [IsoId("_IBkAndcBEeq_l4BJLVUF2Q")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestedModification10 Modification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestedModification10 Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestedModification10 Modification { get; init; } 
    #else
    public RequestedModification10 Modification { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the investigation that may need to be acted upon by the assignee.
    /// </summary>
    [IsoId("_IBkAn9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Instruction For Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForAssgne")]
    #endif
    [IsoXmlTag("InstrForAssgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForAssignee1? InstructionForAssignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForAssignee1? InstructionForAssignee { get; init; } 
    #else
    public InstructionForAssignee1? InstructionForAssignee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IBkAodcBEeq_l4BJLVUF2Q")]
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


// Since RequestToModifyPaymentV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToModifyPaymentV08.

