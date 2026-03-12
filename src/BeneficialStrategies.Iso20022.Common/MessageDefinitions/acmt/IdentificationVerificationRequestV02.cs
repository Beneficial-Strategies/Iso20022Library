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
/// This record is an implementation of the acmt.023.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The IdentificationVerificationRequest message is sent by an assigner to an assignee. It is used to request the verification of party and/or account identification information.
/// Usage
/// The IdentificationVerificationRequest message is sent before the sending of one or several transactions messages.
/// The IdentificationVerificationRequest message can contain one or more verification requests.
/// </summary>
[Description(@"Scope|The IdentificationVerificationRequest message is sent by an assigner to an assignee. It is used to request the verification of party and/or account identification information.|Usage|The IdentificationVerificationRequest message is sent before the sending of one or several transactions messages.|The IdentificationVerificationRequest message can contain one or more verification requests.")]
[IsoId("_sZX_5FkyEeGeoaLUQk__nA_-973563434")]
[DisplayName("Identification Verification Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationVerificationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.023.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02";
    
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
    /// Constructs a IdentificationVerificationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IdentificationVerificationRequestV02( IdentificationAssignment2 reqAssignment,IdentificationVerification2 reqVerification )
    {
        Assignment = reqAssignment;
        Verification = reqVerification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_sZhw4FkyEeGeoaLUQk__nA_798485555")]
    [DisplayName("Assignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnmt")]
    #endif
    [IsoXmlTag("Assgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationAssignment2 Assignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationAssignment2 Assignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationAssignment2 Assignment { get; init; } 
    #else
    public IdentificationAssignment2 Assignment { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the identification data that is requested to be verified.
    /// </summary>
    [IsoId("_sZhw4VkyEeGeoaLUQk__nA_-198586798")]
    [DisplayName("Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrfctn")]
    #endif
    [IsoXmlTag("Vrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationVerification2 Verification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationVerification2 Verification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationVerification2 Verification { get; init; } 
    #else
    public IdentificationVerification2 Verification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sZhw4lkyEeGeoaLUQk__nA_-298368566")]
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


// Since IdentificationVerificationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IdentificationVerificationRequestV02.

