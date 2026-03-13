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
    
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_1IisAwy4EeS3puOfnJm56A")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the related message at the origin of the report or sent at the same time than the report.
    /// </summary>
    [IsoId("_1IisBQy4EeS3puOfnJm56A")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public MessageIdentification1? RelatedMessageReference { get; init; } 
    
    /// <summary>
    /// Type of baseline report.
    /// </summary>
    [IsoId("_1IisBwy4EeS3puOfnJm56A")]
    [DisplayName("Report Type")]
    [IsoXmlTag("RptTp")]
    public required ReportType2 ReportType { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_1IisCQy4EeS3puOfnJm56A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_1IisCwy4EeS3puOfnJm56A")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification6 EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_1IisDQy4EeS3puOfnJm56A")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_1IisDwy4EeS3puOfnJm56A")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_1IisEQy4EeS3puOfnJm56A")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_1IisEwy4EeS3puOfnJm56A")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_1IisFQy4EeS3puOfnJm56A")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_1IisFwy4EeS3puOfnJm56A")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Information on the goods.
    /// </summary>
    [IsoId("_1IisGQy4EeS3puOfnJm56A")]
    [DisplayName("Reported Line Item")]
    [IsoXmlTag("RptdLineItm")]
    public required LineItem14 ReportedLineItem { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_1IisGwy4EeS3puOfnJm56A")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since BaselineReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BaselineReportV04.

