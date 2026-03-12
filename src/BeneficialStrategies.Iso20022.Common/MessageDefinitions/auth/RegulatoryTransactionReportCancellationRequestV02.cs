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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.009.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReportCancellationRequest to a regulator or to an intermediary (eg a reporting agent), to request a cancellation of a previously sent RegulatoryTransactionReport.
/// Usage
/// The message definition can be used to cancel an entire RegulatoryTransactionReport or to cancel one or more individual transactions in a previously sent RegulatoryTransactionReport.
/// </summary>
[Description(@"Scope|A reporting institution, eg, an investment bank, sends the RegulatoryTransactionReportCancellationRequest to a regulator or to an intermediary (eg a reporting agent), to request a cancellation of a previously sent RegulatoryTransactionReport.|Usage|The message definition can be used to cancel an entire RegulatoryTransactionReport or to cancel one or more individual transactions in a previously sent RegulatoryTransactionReport.")]
[IsoId("_gJOkFMIFEeGllrOKQRUTYA_-2116922160")]
[DisplayName("Regulatory Transaction Report Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryTransactionReportCancellationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.009.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.009.001.02";
    
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
    /// Constructs a RegulatoryTransactionReportCancellationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryTransactionReportCancellationRequestV02( DocumentIdentification8 reqIdentification,PartyIdentification23Choice_ reqReportingInstitution,TransactionDetails3 reqCancellationByTransactionDetails,DocumentIdentification9 reqPreviousReference,TransactionDetails2 reqCancellationByTradeReference )
    {
        Identification = reqIdentification;
        ReportingInstitution = reqReportingInstitution;
        CancellationByTransactionDetails = reqCancellationByTransactionDetails;
        PreviousReference = reqPreviousReference;
        CancellationByTradeReference = reqCancellationByTradeReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the RegulatoryTransactionReportCancellationRequest document.
    /// </summary>
    [IsoId("_gJYVEMIFEeGllrOKQRUTYA_-2116922142")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the firm that executed the transaction.|.
    /// </summary>
    [IsoId("_gJYVEcIFEeGllrOKQRUTYA_-2116922021")]
    [DisplayName("Reporting Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgInstn")]
    #endif
    [IsoXmlTag("RptgInstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #else
    public PartyIdentification23Choice_ ReportingInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the intermediary which is reporting on behalf on the reporting institution.
    /// </summary>
    [IsoId("_gJYVEsIFEeGllrOKQRUTYA_-2116921978")]
    [DisplayName("Reporting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgAgt")]
    #endif
    [IsoXmlTag("RptgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification24Choice_? ReportingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification24Choice_? ReportingAgent { get; init; } 
    #else
    public PartyIdentification24Choice_? ReportingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Provides all the details of the transaction report that needs to be cancelled. More than one set of details can be provided.||.
    /// </summary>
    [IsoId("_gJYVE8IFEeGllrOKQRUTYA_-2116922081")]
    [DisplayName("Cancellation By Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByTxDtls")]
    #endif
    [IsoXmlTag("CxlByTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionDetails3 CancellationByTransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionDetails3 CancellationByTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails3 CancellationByTransactionDetails { get; init; } 
    #else
    public TransactionDetails3 CancellationByTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference of the RegulatoryTransactionReport document that was previously sent and that needs to be cancelled in its entirety.
    /// </summary>
    [IsoId("_gJYVFMIFEeGllrOKQRUTYA_-2116922099")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification9 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification9 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification9 PreviousReference { get; init; } 
    #else
    public DocumentIdentification9 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the trade reference of the transaction report that needs to be cancelled. More than one reference may be provided.
    /// </summary>
    [IsoId("_gJiGEMIFEeGllrOKQRUTYA_-2116922038")]
    [DisplayName("Cancellation By Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByTradRef")]
    #endif
    [IsoXmlTag("CxlByTradRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionDetails2 CancellationByTradeReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionDetails2 CancellationByTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails2 CancellationByTradeReference { get; init; } 
    #else
    public TransactionDetails2 CancellationByTradeReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RegulatoryTransactionReportCancellationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RegulatoryTransactionReportCancellationRequestV02.

