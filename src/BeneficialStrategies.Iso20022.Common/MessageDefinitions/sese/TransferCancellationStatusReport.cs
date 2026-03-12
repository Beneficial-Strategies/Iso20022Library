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
/// This record is an implementation of the sese.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferCancellationStatusReport message is sent by an executing party to the instructing party.
/// The message gives the status of a transfer cancellation instruction that was previously sent by the instructing party.
/// Usage
/// The TransferCancellationStatusReport message is sent by an executing party to the instructing party. The message can be used to report that either
/// - the cancellation has been acted upon or
/// - the cancellation is rejected.
/// In both cases, the reason must be specified using either a code or unstructured information.
/// </summary>
[Description(@"Scope|The TransferCancellationStatusReport message is sent by an executing party to the instructing party.|The message gives the status of a transfer cancellation instruction that was previously sent by the instructing party.|Usage|The TransferCancellationStatusReport message is sent by an executing party to the instructing party. The message can be used to report that either|- the cancellation has been acted upon or|- the cancellation is rejected.|In both cases, the reason must be specified using either a code or unstructured information.")]
[IsoId("_HFtUYNE6Ed-BzquC8wXy7w_1729523466")]
[DisplayName("Transfer Cancellation Status Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferCancellationStatusReport : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.010.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.01";
    
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
    /// Constructs a TransferCancellationStatusReport instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferCancellationStatusReport( AdditionalReference2 reqOtherReference,CancellationStatusAndReason reqStatusReport )
    {
        OtherReference = reqOtherReference;
        StatusReport = reqStatusReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_HFtUYdE6Ed-BzquC8wXy7w_1157267444")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference2> RelatedReference { get; init; } = new ValueList<AdditionalReference2>(){};
    
    /// <summary>
    /// Reference to the linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_HFtUYtE6Ed-BzquC8wXy7w_1159114780")]
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
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_HFtUY9E6Ed-BzquC8wXy7w_-503487552")]
    [DisplayName("Status Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRpt")]
    #endif
    [IsoXmlTag("StsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationStatusAndReason StatusReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationStatusAndReason StatusReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusAndReason StatusReport { get; init; } 
    #else
    public CancellationStatusAndReason StatusReport { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TransferCancellationStatusReportDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferCancellationStatusReport.

