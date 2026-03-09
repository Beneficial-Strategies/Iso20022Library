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


namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.041.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransactionReport message is sent by the matching application to the requester of a transaction report.
/// This message is used to report on various details of transactions registered in the matching application.
/// Usage
/// The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.
/// </summary>
[Description(@"Scope|The TransactionReport message is sent by the matching application to the requester of a transaction report.|This message is used to report on various details of transactions registered in the matching application.|Usage|The TransactionReport message can be sent by the matching application to report on various details of transactions that the requester of the report asked for. The message is sent in response to a TransactionReportRequest message.")]
[IsoId("_2UxmeNE8Ed-BzquC8wXy7w_-1389761233")]
[DisplayName("Transaction Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.041.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03";
    
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
    /// Constructs a TransactionReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReportV03( MessageIdentification1 reqReportIdentification,MessageIdentification1 reqRelatedMessageReference )
    {
        ReportIdentification = reqReportIdentification;
        RelatedMessageReference = reqRelatedMessageReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_2UxmedE8Ed-BzquC8wXy7w_-1389761119")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 ReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 ReportIdentification { get; init; } 
    #else
    public MessageIdentification1 ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the previous message requesting the report.
    /// </summary>
    [IsoId("_2U6wYNE8Ed-BzquC8wXy7w_-1389760800")]
    [DisplayName("Related Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdMsgRef")]
    #endif
    [IsoXmlTag("RltdMsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RelatedMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RelatedMessageReference { get; init; } 
    #else
    public MessageIdentification1 RelatedMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of the items that correspond to the parameters set in the request.
    /// </summary>
    [IsoId("_2U6wYdE8Ed-BzquC8wXy7w_-1389761189")]
    [DisplayName("Reported Items")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdItms")]
    #endif
    [IsoXmlTag("RptdItms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionReportItems3? ReportedItems { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReportItems3? ReportedItems { get; init; } 
    #else
    public TransactionReportItems3? ReportedItems { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TransactionReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransactionReportV03.

