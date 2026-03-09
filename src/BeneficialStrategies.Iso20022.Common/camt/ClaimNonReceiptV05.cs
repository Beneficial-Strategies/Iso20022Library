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
/// This record is an implementation of the camt.027.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a Claim Non Receipt message to its account servicing institution is not retained.|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a Claim Non Receipt message to the sender of the original payment instruction.|The Claim Non Receipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple Claim Non Receipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a Resolution Of Investigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on Resolution Of Investigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a Resolution Of Investigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The Claim Non Receipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case Identification: |The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s).|- Underlying Payment: |The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- MissingCoverIndicator: |The MissingCoverIndication element distinguishes between a missing cover situation (when set to YES) or a missing funds situation (when set to NO).|- CoverCorrection|The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.
/// </summary>
[Description(@"Scope|The Claim Non Receipt message is sent by a case creator/case assigner to a case assignee.|This message is used to initiate an investigation for missing funds at the creditor (missing credit entry to its account) or at an agent along the processing chain (missing cover for a received payment instruction).|Usage|The claim non receipt case occurs in two situations: |- The creditor is expecting funds from a particular debtor and cannot find the corresponding credit entry on its account. In this situation, it is understood that the creditor will contact its debtor, and that the debtor will trigger the claim non receipt case on its behalf. A workflow where the creditor directly addresses a Claim Non Receipt message to its account servicing institution is not retained.|- An agent in the processing chain cannot find a cover payment corresponding to a received payment instruction. In this situation, the agent may directly trigger the investigation by sending a Claim Non Receipt message to the sender of the original payment instruction.|The Claim Non Receipt message covers one and only one payment instruction at a time. If several expected payment instructions/cover instructions are found missing, then multiple Claim Non Receipt messages must be sent.|Depending on the result of the investigation by a case assignee (incorrect routing, errors/omissions when processing the instruction or even the absence of an error) and the stage at which the payment instruction is being process, the claim non receipt case may lead to a: |- Request To Cancel Payment message, sent to the subsequent agent in the payment processing chain, if the original payment instruction has been incorrectly routed through the chain of agents. (This also implies that a new, corrected, payment instruction is issued).|- Request To Modify Payment message, sent to the subsequent agent in the payment processing chain, if a truncation or omission has occurred during the processing of the original payment instruction.|If the above situations occur, the assignee wanting to request a payment cancellation or payment modification should first send out a Resolution Of Investigation with a confirmation status that indicates that either cancellation (CWFW) modification (MWFW) or unable to apply (UWFW) will follow. (See section on Resolution Of Investigation for more details).|In the cover is missing, the case assignee may also simply issue the omitted cover payment or when the initial cover information was incorrect, update the cover (through modification and/or cancellation as required) with the correction information provided in the ClaimNonReceipt message. The case assignee will issue a Resolution Of Investigation message with the CorrectionTransaction element mentioning the references of the cover payment.|The Claim Non Receipt message may be forwarded to subsequent case assignees.|The ClaimNonReceipt message has the following main characteristics: |- Case Identification: |The case creator assigns a unique case identification. This information will be passed unchanged to subsequent case assignee(s).|- Underlying Payment: |The case creator refers to the underlying payment instruction for the unambiguous identification of the payment instruction. This identification needs to be updated by the subsequent case assigner(s) in order to match the one used with their case assignee(s).|- MissingCoverIndicator: |The MissingCoverIndication element distinguishes between a missing cover situation (when set to YES) or a missing funds situation (when set to NO).|- CoverCorrection|The CoverCorrection element allows the case assigner to provide corrected cover information, when these are incorrect in the underlying payment instruction for which the cover is issued.")]
[IsoId("_00NMwWXoEeap-P22vGV91g")]
[DisplayName("Claim Non Receipt V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClaimNonReceiptV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.027.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ClmNonRct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.027.001.05";
    
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
    /// Constructs a ClaimNonReceiptV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClaimNonReceiptV05( CaseAssignment3 reqAssignment,Case3 reqCase,UnderlyingTransaction3Choice_ reqUnderlying )
    {
        Assignment = reqAssignment;
        Case = reqCase;
        Underlying = reqUnderlying;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_00NMzWXoEeap-P22vGV91g")]
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
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_00NMz2XoEeap-P22vGV91g")]
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
    /// Identifies the payment instruction for which the Creditor has not received the funds.|Usage: In case of a missing cover, it must be the identification of the related payment instruction.|In case of a claim non receipt initiated by the debtor, it must be the identification of the instruction.
    /// </summary>
    [IsoId("_00NM0WXoEeap-P22vGV91g")]
    [DisplayName("Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Undrlyg")]
    #endif
    [IsoXmlTag("Undrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingTransaction3Choice_ Underlying { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingTransaction3Choice_ Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTransaction3Choice_ Underlying { get; init; } 
    #else
    public UnderlyingTransaction3Choice_ Underlying { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the cover related information of a claim non receipt investigation. The absence of the component means that the message is not a cover related investigation.
    /// </summary>
    [IsoId("_00NM02XoEeap-P22vGV91g")]
    [DisplayName("Cover Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverDtls")]
    #endif
    [IsoXmlTag("CoverDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MissingCover3? CoverDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MissingCover3? CoverDetails { get; init; } 
    #else
    public MissingCover3? CoverDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_00NM1WXoEeap-P22vGV91g")]
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


// Since ClaimNonReceiptV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ClaimNonReceiptV05.

