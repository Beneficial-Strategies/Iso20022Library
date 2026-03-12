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
/// This record is an implementation of the pain.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The CustomerPaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.
/// The CustomerPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions.
/// The CustomerPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentStatusReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The CustomerPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.|Usage|The CustomerPaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.|The CustomerPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions.|The CustomerPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentStatusReport message can be used in domestic and cross-border scenarios.")]
[IsoId("_GXeWaNEvEd-BzquC8wXy7w_246698582")]
[DisplayName("Customer Payment Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerPaymentStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.002.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.002.001.03";
    
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
    /// Constructs a CustomerPaymentStatusReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerPaymentStatusReportV03( GroupHeader36 reqGroupHeader,OriginalGroupInformation20 reqOriginalGroupInformationAndStatus )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformationAndStatus = reqOriginalGroupInformationAndStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status report message.
    /// </summary>
    [IsoId("_GXeWadEvEd-BzquC8wXy7w_949231273")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader36 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader36 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader36 GroupHeader { get; init; } 
    #else
    public GroupHeader36 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_GXeWatEvEd-BzquC8wXy7w_1351887944")]
    [DisplayName("Original Group Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupInformation20 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalGroupInformation20 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation20 OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupInformation20 OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_GXeWa9EvEd-BzquC8wXy7w_-667525122")]
    [DisplayName("Original Payment Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInformation1? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInformation1? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInformation1? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CustomerPaymentStatusReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerPaymentStatusReportV03.

