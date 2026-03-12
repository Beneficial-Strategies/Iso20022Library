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
/// This record is an implementation of the tsmt.018.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.
/// This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.
/// Usage
/// The FullPushThroughReport message can be sent by the matching application to a party to convey
/// - the details of an InitialBaselineSubmission message that it has obtained, or
/// - the details of a BaselineResubmission message that it has obtained, or
/// - the details of a BaselineAmendmentRequest message that it has obtained.
/// </summary>
[Description(@"Scope|The FullPushThroughReport message is sent by the matching application to a party involved in a transaction.|This message is used to pass on information that the matching application has received from the submitter. The forwarded information can originate from an InitialBaselineSubmission or BaselineReSubmission or BaselineAmendmentRequest message.|Usage|The FullPushThroughReport message can be sent by the matching application to a party to convey|- the details of an InitialBaselineSubmission message that it has obtained, or|- the details of a BaselineResubmission message that it has obtained, or|- the details of a BaselineAmendmentRequest message that it has obtained.")]
[IsoId("_9e8ZUdNTEeK-v49t1oWkNA")]
[DisplayName("Full Push Through Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FullPushThroughReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.018.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FullPushThrghRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.018.001.04";
    
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
    /// Constructs a FullPushThroughReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FullPushThroughReportV04( MessageIdentification1 reqReportIdentification,SimpleIdentificationInformation reqTransactionIdentification,TransactionStatus4 reqTransactionStatus,ReportType1 reqReportPurpose,Baseline4 reqPushedThroughBaseline )
    {
        ReportIdentification = reqReportIdentification;
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        ReportPurpose = reqReportPurpose;
        PushedThroughBaseline = reqPushedThroughBaseline;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_9e8ZU9NTEeK-v49t1oWkNA")]
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
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_9e8ZVdNTEeK-v49t1oWkNA")]
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
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_9e8ZV9NTEeK-v49t1oWkNA")]
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
    [IsoId("_9e8ZWdNTEeK-v49t1oWkNA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for the financial institution which submitted the baseline.
    /// </summary>
    [IsoId("_9e8ZW9NTEeK-v49t1oWkNA")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Specifies the type of report.
    /// </summary>
    [IsoId("_9e8ZXdNTEeK-v49t1oWkNA")]
    [DisplayName("Report Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptPurp")]
    #endif
    [IsoXmlTag("RptPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportType1 ReportPurpose { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportType1 ReportPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportType1 ReportPurpose { get; init; } 
    #else
    public ReportType1 ReportPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_9e9AYdNTEeK-v49t1oWkNA")]
    [DisplayName("Pushed Through Baseline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PushdThrghBaseln")]
    #endif
    [IsoXmlTag("PushdThrghBaseln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Baseline4 PushedThroughBaseline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Baseline4 PushedThroughBaseline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Baseline4 PushedThroughBaseline { get; init; } 
    #else
    public Baseline4 PushedThroughBaseline { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_9e9AY9NTEeK-v49t1oWkNA")]
    [DisplayName("Buyer Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrCtctPrsn")]
    #endif
    [IsoXmlTag("BuyrCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? BuyerContactPerson { get; init; } 
    #else
    public ContactIdentification1? BuyerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_9e9AZdNTEeK-v49t1oWkNA")]
    [DisplayName("Seller Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrCtctPrsn")]
    #endif
    [IsoXmlTag("SellrCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? SellerContactPerson { get; init; } 
    #else
    public ContactIdentification1? SellerContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the buyer&apos;s bank.
    /// </summary>
    [IsoId("_9e9AZ9NTEeK-v49t1oWkNA")]
    [DisplayName("Buyer Bank Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBkCtctPrsn")]
    #endif
    [IsoXmlTag("BuyrBkCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? BuyerBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? BuyerBankContactPerson { get; init; } 
    #else
    public ContactIdentification1? BuyerBankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in the seller&apos;s bank.
    /// </summary>
    [IsoId("_9e9AadNTEeK-v49t1oWkNA")]
    [DisplayName("Seller Bank Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBkCtctPrsn")]
    #endif
    [IsoXmlTag("SellrBkCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? SellerBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? SellerBankContactPerson { get; init; } 
    #else
    public ContactIdentification1? SellerBankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_9e9Aa9NTEeK-v49t1oWkNA")]
    [DisplayName("Other Bank Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrBkCtctPrsn")]
    #endif
    [IsoXmlTag("OthrBkCtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification3? OtherBankContactPerson { get; init; } 
    #else
    public ContactIdentification3? OtherBankContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_9e9AbdNTEeK-v49t1oWkNA")]
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


// Since FullPushThroughReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FullPushThroughReportV04.

