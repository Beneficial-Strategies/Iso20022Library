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


namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.014.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// </summary>
[Description(@"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).")]
[IsoId("_CUa3cdcBEeq_l4BJLVUF2Q")]
[DisplayName("Creditor Payment Activation Request Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorPaymentActivationRequestStatusReportV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.014.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.09";
    
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
    /// Constructs a CreditorPaymentActivationRequestStatusReportV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV09( GroupHeader87 reqGroupHeader,OriginalGroupInformation30 reqOriginalGroupInformationAndStatus )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformationAndStatus = reqOriginalGroupInformationAndStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_CUbekdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader87 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader87 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader87 GroupHeader { get; init; } 
    #else
    public GroupHeader87 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_CUbek9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Original Group Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupInformation30 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalGroupInformation30 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation30 OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupInformation30 OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_CUbeldcBEeq_l4BJLVUF2Q")]
    [DisplayName("Original Payment Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction42? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction42? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInstruction42? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CUbel9cBEeq_l4BJLVUF2Q")]
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


// Since CreditorPaymentActivationRequestStatusReportV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreditorPaymentActivationRequestStatusReportV09.

