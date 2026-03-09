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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInstructionStatusReport message is sent by an instructing party to the executing party. The instructing party may be an investor, a transfer agent, or an intermediary, etc. The executing party may be a transfer agent, or an intermediary, etc.
/// This message gives the status of a transfer instruction, and can be used from the time the executing party receives the transfer instruction until its execution.
/// Usage
/// The TransferInstructionStatusReport message is sent by an executing party to the instructing party. The message can be used to report one of the following
/// - the status of the transfer instruction (using a code)or
/// - the repair status or
/// - the unmatched status or
/// - the rejection status or
/// - the pending settlement status.
/// Further information about repair, unmatched, rejected or pending settlement statuses must be specified using either codes or unstructured information.
/// </summary>
[Description(@"Scope|The TransferInstructionStatusReport message is sent by an instructing party to the executing party. The instructing party may be an investor, a transfer agent, or an intermediary, etc. The executing party may be a transfer agent, or an intermediary, etc.|This message gives the status of a transfer instruction, and can be used from the time the executing party receives the transfer instruction until its execution.|Usage|The TransferInstructionStatusReport message is sent by an executing party to the instructing party. The message can be used to report one of the following|- the status of the transfer instruction (using a code)or|- the repair status or|- the unmatched status or|- the rejection status or|- the pending settlement status.|Further information about repair, unmatched, rejected or pending settlement statuses must be specified using either codes or unstructured information.")]
[IsoId("_K0uj29E6Ed-BzquC8wXy7w_569643185")]
[DisplayName("Transfer Instruction Status Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInstructionStatusReport : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.011.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.01";
    
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
    /// Constructs a TransferInstructionStatusReport instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInstructionStatusReport( AdditionalReference2 reqRelatedReference,AdditionalReference2 reqOtherReference,TransferStatusAndReason reqStatusReport )
    {
        RelatedReference = reqRelatedReference;
        OtherReference = reqOtherReference;
        StatusReport = reqStatusReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K0uj3NE6Ed-BzquC8wXy7w_902110432")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 RelatedReference { get; init; } 
    #else
    public AdditionalReference2 RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_K04U0NE6Ed-BzquC8wXy7w_900264708")]
    [DisplayName("Other Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRef")]
    #endif
    [IsoXmlTag("OthrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference2 OtherReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference2 OtherReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2 OtherReference { get; init; } 
    #else
    public AdditionalReference2 OtherReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_K04U0dE6Ed-BzquC8wXy7w_2104535600")]
    [DisplayName("Status Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRpt")]
    #endif
    [IsoXmlTag("StsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferStatusAndReason StatusReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferStatusAndReason StatusReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatusAndReason StatusReport { get; init; } 
    #else
    public TransferStatusAndReason StatusReport { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TransferInstructionStatusReportDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInstructionStatusReport.

