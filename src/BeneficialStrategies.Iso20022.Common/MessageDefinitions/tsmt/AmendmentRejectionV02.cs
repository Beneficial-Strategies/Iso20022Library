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
/// This record is an implementation of the tsmt.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendmentRejection message is sent by the party requested to accept or reject an amendment to the matching application.
/// This message is used to reject an amendment request.
/// Usage
/// The AmendmentRejection message can be sent by the party requested to accept or reject an amendment to inform that it rejects the requested amendment.
/// The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.
/// The acceptance of an amendment request can be achieved by sending an AmendmentAcceptance message.
/// </summary>
[Description(@"Scope|The AmendmentRejection message is sent by the party requested to accept or reject an amendment to the matching application.|This message is used to reject an amendment request.|Usage|The AmendmentRejection message can be sent by the party requested to accept or reject an amendment to inform that it rejects the requested amendment.|The message can be sent in response to a FullPushThroughReport and DeltaReport message conveying the details of a BaselineAmendmentRequest message.|The acceptance of an amendment request can be achieved by sending an AmendmentAcceptance message.")]
[IsoId("_krHoKNE8Ed-BzquC8wXy7w_-1775142973")]
[DisplayName("Amendment Rejection V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendmentRejectionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdmntRjctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.007.001.02";
    
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
    /// Constructs a AmendmentRejectionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmendmentRejectionV02( MessageIdentification1 reqRejectionIdentification,SimpleIdentificationInformation reqTransactionIdentification,MessageIdentification1 reqDeltaReportReference,Count1 reqRejectedAmendmentNumber,RejectionReason1Choice_ reqRejectionReason )
    {
        RejectionIdentification = reqRejectionIdentification;
        TransactionIdentification = reqTransactionIdentification;
        DeltaReportReference = reqDeltaReportReference;
        RejectedAmendmentNumber = reqRejectedAmendmentNumber;
        RejectionReason = reqRejectionReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_krHoKdE8Ed-BzquC8wXy7w_-1775142819")]
    [DisplayName("Rejection Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnId")]
    #endif
    [IsoXmlTag("RjctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RejectionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RejectionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RejectionIdentification { get; init; } 
    #else
    public MessageIdentification1 RejectionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_krHoKtE8Ed-BzquC8wXy7w_-1775142850")]
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
    [IsoId("_krHoK9E8Ed-BzquC8wXy7w_-1775142970")]
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
    /// Reference to the identification of the delta report that contained the amendment.
    /// </summary>
    [IsoId("_krHoLNE8Ed-BzquC8wXy7w_-1775142881")]
    [DisplayName("Delta Report Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DltaRptRef")]
    #endif
    [IsoXmlTag("DltaRptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 DeltaReportReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 DeltaReportReference { get; init; } 
    #else
    public MessageIdentification1 DeltaReportReference { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence number of the rejected baseline amendment.
    /// </summary>
    [IsoId("_krHoLdE8Ed-BzquC8wXy7w_-1775142942")]
    [DisplayName("Rejected Amendment Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdAmdmntNb")]
    #endif
    [IsoXmlTag("RjctdAmdmntNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Count1 RejectedAmendmentNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Count1 RejectedAmendmentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Count1 RejectedAmendmentNumber { get; init; } 
    #else
    public Count1 RejectedAmendmentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reaons for rejecting the amendment.
    /// </summary>
    [IsoId("_krQyENE8Ed-BzquC8wXy7w_-1775142911")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason1Choice_ RejectionReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReason1Choice_ RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason1Choice_ RejectionReason { get; init; } 
    #else
    public RejectionReason1Choice_ RejectionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AmendmentRejectionV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendmentRejectionV02.

