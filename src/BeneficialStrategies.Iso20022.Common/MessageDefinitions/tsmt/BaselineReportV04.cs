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
/// This record is an implementation of the tsmt.011.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BaselineReport message is sent by the matching application to the parties involved in an amendment request or to the parties involved in a data set match.
/// The message is used to report either a pre-calculation or final calculation of the dynamic part of an established baseline.
/// Usage
/// The BaselineReport message can be sent by the matching application to the parties involved in an amendment request for a transaction established in the push-through mode. In the outlined scenario, the message is sent
/// - to the party requested to accept or reject an amendment request after the matching application has received a BaselineAmendmentRequest message. The message informs about the provisional status of the dynamic part of the baseline.
/// - to the requester and the accepter of an amendment request after the matching application has received an AmendmentAcceptance message conveying the acceptance of the amendment request. The message informs about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the party which has sent an amendment request for a transaction established in the lodge mode. In the outlined scenario the message is used to inform about the actual status of the dynamic part of the baseline.
/// or
/// The BaselineReport message can be sent by the matching application to the parties involved in a data set match. In the outlined scenario, the message is sent
/// - to the submitter of the data set(s) in the case of a data set match for a transaction established in the lodge mode.
/// - to the submitter of the data set(s) and to the counterparty in case of a data set match for a transaction established in the push-through mode.The message can be sent after a successful data-set match or after the acceptance of mis-matched data sets to inform about the actual status of the dynamic part of the baseline.
/// </summary>
[Description(@"Scope|The BaselineReport message is sent by the matching application to the parties involved in an amendment request or to the parties involved in a data set match.|The message is used to report either a pre-calculation or final calculation of the dynamic part of an established baseline.|Usage|The BaselineReport message can be sent by the matching application to the parties involved in an amendment request for a transaction established in the push-through mode. In the outlined scenario, the message is sent|- to the party requested to accept or reject an amendment request after the matching application has received a BaselineAmendmentRequest message. The message informs about the provisional status of the dynamic part of the baseline.|- to the requester and the accepter of an amendment request after the matching application has received an AmendmentAcceptance message conveying the acceptance of the amendment request. The message informs about the actual status of the dynamic part of the baseline.|or|The BaselineReport message can be sent by the matching application to the party which has sent an amendment request for a transaction established in the lodge mode. In the outlined scenario the message is used to inform about the actual status of the dynamic part of the baseline.|or|The BaselineReport message can be sent by the matching application to the parties involved in a data set match. In the outlined scenario, the message is sent|- to the submitter of the data set(s) in the case of a data set match for a transaction established in the lodge mode.|- to the submitter of the data set(s) and to the counterparty in case of a data set match for a transaction established in the push-through mode.The message can be sent after a successful data-set match or after the acceptance of mis-matched data sets to inform about the actual status of the dynamic part of the baseline.")]
[IsoId("_1IisAQy4EeS3puOfnJm56A")]
[DisplayName("Baseline Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BaselineReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.011.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.04";
    
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
    /// Constructs a BaselineReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BaselineReportV04( MessageIdentification1 reqReportIdentification,ReportType2 reqReportType,SimpleIdentificationInformation reqTransactionIdentification,DocumentIdentification6 reqEstablishedBaselineIdentification,TransactionStatus4 reqTransactionStatus,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank,LineItem14 reqReportedLineItem )
    {
        ReportIdentification = reqReportIdentification;
        ReportType = reqReportType;
        TransactionIdentification = reqTransactionIdentification;
        EstablishedBaselineIdentification = reqEstablishedBaselineIdentification;
        TransactionStatus = reqTransactionStatus;
        Buyer = reqBuyer;
        Seller = reqSeller;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
        ReportedLineItem = reqReportedLineItem;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_1IisAwy4EeS3puOfnJm56A")]
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
    /// Reference to the related message at the origin of the report or sent at the same time than the report.
    /// </summary>
    [IsoId("_1IisBQy4EeS3puOfnJm56A")]
    [DisplayName("Related Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdMsgRef")]
    #endif
    [IsoXmlTag("RltdMsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? RelatedMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? RelatedMessageReference { get; init; } 
    #else
    public MessageIdentification1? RelatedMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of baseline report.
    /// </summary>
    [IsoId("_1IisBwy4EeS3puOfnJm56A")]
    [DisplayName("Report Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTp")]
    #endif
    [IsoXmlTag("RptTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportType2 ReportType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportType2 ReportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportType2 ReportType { get; init; } 
    #else
    public ReportType2 ReportType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_1IisCQy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisCwy4EeS3puOfnJm56A")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification6 EstablishedBaselineIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification6 EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification6 EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification6 EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_1IisDQy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisDwy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisEQy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisEwy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisFQy4EeS3puOfnJm56A")]
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
    [IsoId("_1IisFwy4EeS3puOfnJm56A")]
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
    /// Information on the goods.
    /// </summary>
    [IsoId("_1IisGQy4EeS3puOfnJm56A")]
    [DisplayName("Reported Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdLineItm")]
    #endif
    [IsoXmlTag("RptdLineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LineItem14 ReportedLineItem { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LineItem14 ReportedLineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItem14 ReportedLineItem { get; init; } 
    #else
    public LineItem14 ReportedLineItem { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_1IisGwy4EeS3puOfnJm56A")]
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


// Since BaselineReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BaselineReportV04.

