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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.024.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IdentificationVerificationReport message is sent by an assigner to an assignee. It is used to confirm whether or not the presented party and/or account identification information is correct.
/// Usage
/// The IdentificationVerificationReport message is sent as a response to an IdentificationVerificationRequest message.
/// The IdentificationVerificationReport message can contain one or more reports.
/// The IdentificationVerificationReport message may include a reason if the presented party and/or account identification information is confirmed to be incorrect.
/// The IdentificationVerificationReport message may include the correct party and/or account identification information.
/// </summary>
[Description(@"Scope|The IdentificationVerificationReport message is sent by an assigner to an assignee. It is used to confirm whether or not the presented party and/or account identification information is correct.|Usage|The IdentificationVerificationReport message is sent as a response to an IdentificationVerificationRequest message.|The IdentificationVerificationReport message can contain one or more reports.|The IdentificationVerificationReport message may include a reason if the presented party and/or account identification information is confirmed to be incorrect.|The IdentificationVerificationReport message may include the correct party and/or account identification information.")]
[IsoId("_dgmtEwyYEeukGOovyT2RcQ")]
[DisplayName("Identification Verification Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationVerificationReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.024.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.03";
    
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
    /// Constructs a IdentificationVerificationReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IdentificationVerificationReportV03( IdentificationAssignment3 reqAssignment,VerificationReport4 reqReport )
    {
        Assignment = reqAssignment;
        Report = reqReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_dgmtFAyYEeukGOovyT2RcQ")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationAssignment3 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationAssignment3 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationAssignment3 Assignment { get; init; } 
    #else
    public IdentificationAssignment3 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides for the reference to the original identification assignment.
    /// </summary>
    [IsoId("_dgnUEgyYEeukGOovyT2RcQ")]
    [DisplayName("Original Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAssgnmt")]
    #endif
    [IsoXmlTag("OrgnlAssgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification7? OriginalAssignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification7? OriginalAssignment { get; init; } 
    #else
    public MessageIdentification7? OriginalAssignment { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the verification of the identification data for which verification was requested.
    /// </summary>
    [IsoId("_dgnUEAyYEeukGOovyT2RcQ")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VerificationReport4 Report { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VerificationReport4 Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationReport4 Report { get; init; } 
    #else
    public VerificationReport4 Report { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dgnUEQyYEeukGOovyT2RcQ")]
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


// Since IdentificationVerificationReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IdentificationVerificationReportV03.

