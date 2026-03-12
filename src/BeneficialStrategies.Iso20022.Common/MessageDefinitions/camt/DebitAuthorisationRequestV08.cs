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
/// This record is an implementation of the camt.037.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DebitAuthorisationRequest message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.
/// Usage
/// The DebitAuthorisationRequest message must be answered with a DebitAuthorisationResponse message.
/// The DebitAuthorisationRequest message can be used to request debit authorisation in a:
/// - request to modify payment case (in the case of a lower final amount or change of creditor);
/// - request to cancel payment case (full amount);
/// - unable to apply case (the creditor whose account has been credited is not the intended beneficiary);
/// - claim non receipt case (the creditor whose account has been credited is not the intended beneficiary).
/// The DebitAuthorisationRequest message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple DebitAuthorisationRequest messages must be sent.
/// The DebitAuthorisationRequest must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a RequestToModifyPayment or CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message between subsequent agents.
/// </summary>
[Description(@"Scope|The DebitAuthorisationRequest message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.|Usage|The DebitAuthorisationRequest message must be answered with a DebitAuthorisationResponse message.|The DebitAuthorisationRequest message can be used to request debit authorisation in a:|- request to modify payment case (in the case of a lower final amount or change of creditor);|- request to cancel payment case (full amount);|- unable to apply case (the creditor whose account has been credited is not the intended beneficiary);|- claim non receipt case (the creditor whose account has been credited is not the intended beneficiary).|The DebitAuthorisationRequest message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple DebitAuthorisationRequest messages must be sent.|The DebitAuthorisationRequest must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a RequestToModifyPayment or CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message between subsequent agents.")]
[IsoId("_Lv_l28P_Eemsic1bQcEtLA")]
[DisplayName("Debit Authorisation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebitAuthorisationRequestV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.037.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.037.001.08";
    
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
    /// Constructs a DebitAuthorisationRequestV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebitAuthorisationRequestV08( CaseAssignment5 reqAssignment,UnderlyingTransaction6Choice_ reqUnderlying,DebitAuthorisation2 reqDetail )
    {
        Assignment = reqAssignment;
        Underlying = reqUnderlying;
        Detail = reqDetail;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_LwAMw8P_Eemsic1bQcEtLA")]
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
    [IsoId("_LwAMxcP_Eemsic1bQcEtLA")]
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
    /// Identifies the underlying payment instruction.
    /// </summary>
    [IsoId("_LwAMx8P_Eemsic1bQcEtLA")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingTransaction6Choice_ Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingTransaction6Choice_ Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTransaction6Choice_ Underlying { get; init; } 
    #else
    public UnderlyingTransaction6Choice_ Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the request.
    /// </summary>
    [IsoId("_LwAMycP_Eemsic1bQcEtLA")]
    [DisplayName("Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dtl")]
    #endif
    [IsoXmlTag("Dtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebitAuthorisation2 Detail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebitAuthorisation2 Detail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebitAuthorisation2 Detail { get; init; } 
    #else
    public DebitAuthorisation2 Detail { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LwAMy8P_Eemsic1bQcEtLA")]
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


// Since DebitAuthorisationRequestV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DebitAuthorisationRequestV08.

