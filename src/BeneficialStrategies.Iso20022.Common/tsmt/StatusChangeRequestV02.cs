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
/// This record is an implementation of the tsmt.026.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a change in the status of a transaction.
/// Usage
/// The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.
/// The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message.
/// </summary>
[Description(@"Scope|The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a change in the status of a transaction.|Usage|The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.|The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message.")]
[IsoId("_xjvgaNE8Ed-BzquC8wXy7w_-2117703681")]
[DisplayName("Status Change Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusChangeRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.026.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02";
    
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
    /// Constructs a StatusChangeRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusChangeRequestV02( MessageIdentification1 reqRequestIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus3 reqRequestedStatus )
    {
        RequestIdentification = reqRequestIdentification;
        TransactionIdentification = reqTransactionIdentification;
        RequestedStatus = reqRequestedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_xjvgadE8Ed-BzquC8wXy7w_-2117703678")]
    [DisplayName("Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqId")]
    #endif
    [IsoXmlTag("ReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_xjvgatE8Ed-BzquC8wXy7w_-2117703649")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation TransactionIdentification { get; init; } 
    #else
    public SimpleIdentificationInformation TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_xjvga9E8Ed-BzquC8wXy7w_-2117703588")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; } 
    #else
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the baseline status requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_xjvgbNE8Ed-BzquC8wXy7w_-2117703618")]
    [DisplayName("Requested Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSts")]
    #endif
    [IsoXmlTag("ReqdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus3 RequestedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus3 RequestedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus3 RequestedStatus { get; init; } 
    #else
    public TransactionStatus3 RequestedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the request to change status.
    /// </summary>
    [IsoId("_xjvgbdE8Ed-BzquC8wXy7w_-2117703557")]
    [DisplayName("Request Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRsn")]
    #endif
    [IsoXmlTag("ReqRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reason2? RequestReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reason2? RequestReason { get; init; } 
    #else
    public Reason2? RequestReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StatusChangeRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusChangeRequestV02.

