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
/// This record is an implementation of the camt.008.002.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Request To Cancel Payment message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction.
/// Usage
/// The Request To Cancel Payment message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)
/// - Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested cancellation
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A Request To Cancel Payment message concerns one and only one original payment instruction at a time. If several original payment instructions need to be cancelled, then multiple Request To Cancel Payment messages must be sent.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.
/// The processing of a request to cancel payment case may end with a Debit Authorisation Request message sent to the creditor by its account servicing institution.
/// The Request To Cancel Payment message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Request To Modify Payment message and the element ReopenCaseIndication is set to &apos;Yes&apos; or &apos;true&apos;.
/// </summary>
[Description(@"Scope|The Request To Cancel Payment message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction.|Usage|The Request To Cancel Payment message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)|- Reject Case Assignment message when the case assignee is unable or not authorised to perform the requested cancellation|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A Request To Cancel Payment message concerns one and only one original payment instruction at a time. If several original payment instructions need to be cancelled, then multiple Request To Cancel Payment messages must be sent.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.|The processing of a request to cancel payment case may end with a Debit Authorisation Request message sent to the creditor by its account servicing institution.|The Request To Cancel Payment message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original Request To Modify Payment message and the element ReopenCaseIndication is set to 'Yes' or 'true'.")]
[IsoId("_SsPgaNE_Ed-BzquC8wXy7w_-319126459")]
[DisplayName("Request To Cancel Payment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestToCancelPayment : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.008.002.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.008.002.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.008.002.01";
    
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
    /// Constructs a RequestToCancelPayment instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestToCancelPayment( CaseAssignment reqAssignment,Case reqCase,PaymentInstructionExtract reqUnderlying,DebitAuthorisationDetails reqJustification )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Underlying = reqUnderlying;
        Justification = reqJustification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of a case from an assigner to an assignee.
    /// </summary>
    [IsoId("_SsPgadE_Ed-BzquC8wXy7w_402186084")]
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
    [IsoId("_SsZRYNE_Ed-BzquC8wXy7w_70459884")]
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
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_SsZRYdE_Ed-BzquC8wXy7w_74152854")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstructionExtract Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstructionExtract Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstructionExtract Underlying { get; init; } 
    #else
    public PaymentInstructionExtract Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the reason for requesting the cancellation.
    /// </summary>
    [IsoId("_SsZRYtE_Ed-BzquC8wXy7w_341710652")]
    [DisplayName("Justification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Justfn")]
    #endif
    [IsoXmlTag("Justfn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebitAuthorisationDetails Justification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebitAuthorisationDetails Justification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebitAuthorisationDetails Justification { get; init; } 
    #else
    public DebitAuthorisationDetails Justification { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RequestToCancelPaymentDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestToCancelPayment.

