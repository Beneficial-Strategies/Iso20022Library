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
    
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_m1i4UNE8Ed-BzquC8wXy7w_-439673685")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_m1i4UdE8Ed-BzquC8wXy7w_-439673654")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_m1i4UtE8Ed-BzquC8wXy7w_-439673715")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_m1i4U9E8Ed-BzquC8wXy7w_-439673623")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_m1i4VNE8Ed-BzquC8wXy7w_-439673775")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VdE8Ed-BzquC8wXy7w_-439673168")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_m1i4VtE8Ed-BzquC8wXy7w_-439673229")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1i4V9E8Ed-BzquC8wXy7w_-439673291")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_m1spUNE8Ed-BzquC8wXy7w_-439673345")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Identifies the documents compared in this report.
    /// </summary>
    [IsoId("_m1spUdE8Ed-BzquC8wXy7w_-439674053")]
    [DisplayName("Compared Document Reference")]
    [IsoXmlTag("CmpardDocRef")]
    public ValueList<DocumentIdentification10> ComparedDocumentReference { get; init; } = [];
    // ID for the above is _m1spUdE8Ed-BzquC8wXy7w_-439674053
    
    /// <summary>
    /// Specifies whether the data set was submitted for match or pre-match.
    /// </summary>
    [IsoId("_m1spUtE8Ed-BzquC8wXy7w_-439673137")]
    [DisplayName("Submission Type")]
    [IsoXmlTag("SubmissnTp")]
    public required ReportType3 SubmissionType { get; init; } 
    
    /// <summary>
    /// Description of the differences between the data set(s) and the baseline.
    /// </summary>
    [IsoId("_m1spU9E8Ed-BzquC8wXy7w_-439674024")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public required MisMatchReport3 Report { get; init; } 
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_m1spVNE8Ed-BzquC8wXy7w_-439673260")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since DataSetMatchReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DataSetMatchReportV03.

