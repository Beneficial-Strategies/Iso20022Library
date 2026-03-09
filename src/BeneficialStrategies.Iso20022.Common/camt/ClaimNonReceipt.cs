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
/// This record is an implementation of the camt.027.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message allows to initiate an investigation in case the beneficiary of a payment has not received an expected payment.|Usage|Note 1: Although there are cases where a creditor would contact the creditor&apos;s bank when claiming non-receipt, the activity only retained the scenario where the beneficiary claims non-receipt with its debtor, the debtor in its turn contacting the first agent. Therefore the investigation follows the same route as the original instruction.|Note 2: This message is also used to report a missing cover. The rationale behind this is that the beneficiary of the cover (receiver of the payment instruction) missing the cover would be in the very same position as a beneficiary expecting a credit to its account and would therefore trigger the same processes.|In case of a Missing cover, the case will be assigned to the sender of the payment instruction, before following the route of the payment instruction.
/// </summary>
[Description(@"Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message allows to initiate an investigation in case the beneficiary of a payment has not received an expected payment.|Usage|Note 1: Although there are cases where a creditor would contact the creditor's bank when claiming non-receipt, the activity only retained the scenario where the beneficiary claims non-receipt with its debtor, the debtor in its turn contacting the first agent. Therefore the investigation follows the same route as the original instruction.|Note 2: This message is also used to report a missing cover. The rationale behind this is that the beneficiary of the cover (receiver of the payment instruction) missing the cover would be in the very same position as a beneficiary expecting a credit to its account and would therefore trigger the same processes.|In case of a Missing cover, the case will be assigned to the sender of the payment instruction, before following the route of the payment instruction.")]
[IsoId("_QSbl2NE-Ed-BzquC8wXy7w_1911280425")]
[DisplayName("Claim Non Receipt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClaimNonReceipt : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.027.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.027.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.01";
    
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
    /// Constructs a ClaimNonReceipt instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClaimNonReceipt( CaseAssignment reqAssignment,Case reqCase,PaymentInstructionExtract reqUnderlying )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Underlying = reqUnderlying;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies an assignment.
    /// </summary>
    [IsoId("_QSlW0NE-Ed-BzquC8wXy7w_830291630")]
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
    /// Identifies a case.
    /// </summary>
    [IsoId("_QSlW0dE-Ed-BzquC8wXy7w_843221783")]
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
    /// Identifies the payment instruction for which the Creditor has not received the funds.|Note: |In case of a missing cover, it must be the Field 20 of the received MT103.|In case of a claim non receipt initiated by the Debtor, it must be the identification of the instruction (Field 20 of MT103, Instruction Identification of the Payment Initiation or the Bulk Credit Transfer).
    /// </summary>
    [IsoId("_QSlW0tE-Ed-BzquC8wXy7w_857073686")]
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
    /// Indicates if the claim non receipt is a missing cover. The absence of the component means that the message is not for a missing cover.
    /// </summary>
    [IsoId("_QSlW09E-Ed-BzquC8wXy7w_-476196427")]
    [DisplayName("Missing Cover")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MssngCover")]
    #endif
    [IsoXmlTag("MssngCover")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MissingCover? MissingCover { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MissingCover? MissingCover { get; init; } 
    #else
    public MissingCover? MissingCover { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ClaimNonReceiptDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ClaimNonReceipt.

