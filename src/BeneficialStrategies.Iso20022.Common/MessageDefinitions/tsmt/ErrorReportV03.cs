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
/// This record is an implementation of the tsmt.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ErrorReport message is sent by the matching application to the party from which it received a message.
/// This message is used to inform about the inability of the matching application to process a received message.
/// Usage
/// The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because
/// - the syntax of the message is incorrect,or
/// - the message content is inconsistent,or
/// - according to the workflow implemented in the matching application, it did not expect the received message.
/// </summary>
[Description(@"Scope|The ErrorReport message is sent by the matching application to the party from which it received a message.|This message is used to inform about the inability of the matching application to process a received message.|Usage|The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because|- the syntax of the message is incorrect,or|- the message content is inconsistent,or|- according to the workflow implemented in the matching application, it did not expect the received message.")]
[IsoId("_oHDjhdE8Ed-BzquC8wXy7w_-1687018808")]
[DisplayName("Error Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ErrorReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.016.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ErrRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.016.001.03";
    
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
    /// Constructs a ErrorReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ErrorReportV03( MessageIdentification1 reqReportIdentification,Count1 reqNumberOfErrors,ValidationResult3 reqErrorDescription )
    {
        ReportIdentification = reqReportIdentification;
        NumberOfErrors = reqNumberOfErrors;
        ErrorDescription = reqErrorDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_oHDjhtE8Ed-BzquC8wXy7w_-1686098714")]
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
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_oHDjh9E8Ed-BzquC8wXy7w_-1686098652")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_oHDjiNE8Ed-BzquC8wXy7w_-1686098591")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3? EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_oHDjidE8Ed-BzquC8wXy7w_-1686098560")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionStatus4? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4? TransactionStatus { get; init; } 
    #else
    public TransactionStatus4? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the financial institution which is the sender of the rejected message.
    /// </summary>
    [IsoId("_oHDjitE8Ed-BzquC8wXy7w_-1686098745")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification5? UserTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification5? UserTransactionReference { get; init; } 
    #else
    public DocumentIdentification5? UserTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of the rejected message.
    /// </summary>
    [IsoId("_oHDji9E8Ed-BzquC8wXy7w_-1686098683")]
    [DisplayName("Rejected Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdMsgRef")]
    #endif
    [IsoXmlTag("RjctdMsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? RejectedMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? RejectedMessageReference { get; init; } 
    #else
    public MessageIdentification1? RejectedMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number of errors identified in the rejected message.
    /// </summary>
    [IsoId("_oHNUgNE8Ed-BzquC8wXy7w_-1687018798")]
    [DisplayName("Number Of Errors")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfErrs")]
    #endif
    [IsoXmlTag("NbOfErrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Count1 NumberOfErrors { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Count1 NumberOfErrors { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Count1 NumberOfErrors { get; init; } 
    #else
    public Count1 NumberOfErrors { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the error that is the cause of the rejection.
    /// </summary>
    [IsoId("_oHNUgdE8Ed-BzquC8wXy7w_-1686098797")]
    [DisplayName("Error Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrDesc")]
    #endif
    [IsoXmlTag("ErrDesc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValidationResult3 ErrorDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValidationResult3 ErrorDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationResult3 ErrorDescription { get; init; } 
    #else
    public ValidationResult3 ErrorDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_oHNUgtE8Ed-BzquC8wXy7w_-1686098530")]
    [DisplayName("Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForActn")]
    #endif
    [IsoXmlTag("ReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? RequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? RequestForAction { get; init; } 
    #else
    public PendingActivity2? RequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ErrorReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ErrorReportV03.

