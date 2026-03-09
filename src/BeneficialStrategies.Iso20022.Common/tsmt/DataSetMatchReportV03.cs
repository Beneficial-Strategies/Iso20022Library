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
/// This record is an implementation of the tsmt.013.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DataSetMatchReport message is sent by the matching application to the parties involved in a data set match.
/// This message is used to either
/// - inform about the successful match of data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline,or
/// - inform about mis-matches found between data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline.
/// Usage
/// The DataSetMatchReport message can be sent by the matching application to the party requesting a data set pre-match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful pre-match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// or
/// The DataSetMatchReport message can be sent by the matching application to the parties involved in a data set match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// or
/// The DataSetMatchReport message can be sent by the matching application to the party requesting a data set match or pre-match for a transaction established in the lodge mode. In the outlined scenario, the DataSetMatchReport will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.
/// </summary>
[Description(@"Scope|The DataSetMatchReport message is sent by the matching application to the parties involved in a data set match.|This message is used to either|- inform about the successful match of data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline,or|- inform about mis-matches found between data sets submitted with the instruction match or pre-match (DataSetSubmission message) and the related baseline.|Usage|The DataSetMatchReport message can be sent by the matching application to the party requesting a data set pre-match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful pre-match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.|or|The DataSetMatchReport message can be sent by the matching application to the parties involved in a data set match for a transaction established in the push-through mode. In the outlined scenario, the DataSetMatchReport message will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.|or|The DataSetMatchReport message can be sent by the matching application to the party requesting a data set match or pre-match for a transaction established in the lodge mode. In the outlined scenario, the DataSetMatchReport will either inform about the successful match or list the mis-matches between the data set(s) conveyed with the DataSetSubmission message and the related baseline.")]
[IsoId("_m1ZuaNE8Ed-BzquC8wXy7w_-439674056")]
[DisplayName("Data Set Match Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetMatchReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.013.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DataSetMtchRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.013.001.03";
    
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
    /// Constructs a DataSetMatchReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetMatchReportV03( MessageIdentification1 reqReportIdentification,SimpleIdentificationInformation reqTransactionIdentification,DocumentIdentification3 reqEstablishedBaselineIdentification,TransactionStatus4 reqTransactionStatus,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank,ReportType3 reqSubmissionType,MisMatchReport3 reqReport )
    {
        ReportIdentification = reqReportIdentification;
        TransactionIdentification = reqTransactionIdentification;
        EstablishedBaselineIdentification = reqEstablishedBaselineIdentification;
        TransactionStatus = reqTransactionStatus;
        Buyer = reqBuyer;
        Seller = reqSeller;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
        SubmissionType = reqSubmissionType;
        Report = reqReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_m1i4UNE8Ed-BzquC8wXy7w_-439673685")]
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
    [IsoId("_m1i4UdE8Ed-BzquC8wXy7w_-439673654")]
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
    [IsoId("_m1i4UtE8Ed-BzquC8wXy7w_-439673715")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3 EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_m1i4U9E8Ed-BzquC8wXy7w_-439673623")]
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
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_m1i4VNE8Ed-BzquC8wXy7w_-439673775")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VdE8Ed-BzquC8wXy7w_-439673168")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Buyer { get; init; } 
    #else
    public PartyIdentification26 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VtE8Ed-BzquC8wXy7w_-439673229")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Seller { get; init; } 
    #else
    public PartyIdentification26 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1i4V9E8Ed-BzquC8wXy7w_-439673291")]
    [DisplayName("Buyer Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBk")]
    #endif
    [IsoXmlTag("BuyrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1spUNE8Ed-BzquC8wXy7w_-439673345")]
    [DisplayName("Seller Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBk")]
    #endif
    [IsoXmlTag("SellrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the documents compared in this report.
    /// </summary>
    [IsoId("_m1spUdE8Ed-BzquC8wXy7w_-439674053")]
    [DisplayName("Compared Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpardDocRef")]
    #endif
    [IsoXmlTag("CmpardDocRef")]
    public ValueList<DocumentIdentification10> ComparedDocumentReference { get; init; } = new ValueList<DocumentIdentification10>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _m1spUdE8Ed-BzquC8wXy7w_-439674053
    
    /// <summary>
    /// Specifies whether the data set was submitted for match or pre-match.
    /// </summary>
    [IsoId("_m1spUtE8Ed-BzquC8wXy7w_-439673137")]
    [DisplayName("Submission Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmissnTp")]
    #endif
    [IsoXmlTag("SubmissnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportType3 SubmissionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportType3 SubmissionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportType3 SubmissionType { get; init; } 
    #else
    public ReportType3 SubmissionType { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the differences between the data set(s) and the baseline.
    /// </summary>
    [IsoId("_m1spU9E8Ed-BzquC8wXy7w_-439674024")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MisMatchReport3 Report { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MisMatchReport3 Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MisMatchReport3 Report { get; init; } 
    #else
    public MisMatchReport3 Report { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_m1spVNE8Ed-BzquC8wXy7w_-439673260")]
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


// Since DataSetMatchReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DataSetMatchReportV03.

