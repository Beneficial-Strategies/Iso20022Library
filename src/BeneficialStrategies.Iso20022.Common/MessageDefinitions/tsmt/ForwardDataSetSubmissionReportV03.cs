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
/// This record is an implementation of the tsmt.017.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForwardDataSetSubmissionReport message is sent by the matching application to the counterparty(ies) of the submitter of data sets.
/// This message is used to pass on information related to the purchasing agreement(s) covered by the transaction(s) referred to in the message.
/// Usage
/// The ForwardDataSetSubmission message can be sent by the matching application to forward the details of a DataSetSubmission message that it has obtained.
/// </summary>
[Description(@"Scope|The ForwardDataSetSubmissionReport message is sent by the matching application to the counterparty(ies) of the submitter of data sets.|This message is used to pass on information related to the purchasing agreement(s) covered by the transaction(s) referred to in the message.|Usage|The ForwardDataSetSubmission message can be sent by the matching application to forward the details of a DataSetSubmission message that it has obtained.")]
[IsoId("_oieUONE8Ed-BzquC8wXy7w_403319045")]
[DisplayName("Forward Data Set Submission Report V")]
public partial record ForwardDataSetSubmissionReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.017.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FwdDataSetSubmissnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03";
    
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
    [IsoId("_oieUOdE8Ed-BzquC8wXy7w_403319072")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the transactions that this submission relates to and provides associated information.
    /// </summary>
    [IsoId("_oioFMNE8Ed-BzquC8wXy7w_403320811")]
    [DisplayName("Related Transaction References")]
    [IsoXmlTag("RltdTxRefs")]
    public required DataSetSubmissionReferences4 RelatedTransactionReferences { get; init; } 
    
    /// <summary>
    /// This reference must be used for all data sets belonging to the same submission group.
    /// </summary>
    [IsoId("_oioFMdE8Ed-BzquC8wXy7w_-1228245791")]
    [DisplayName("Common Submission Reference")]
    [IsoXmlTag("CmonSubmissnRef")]
    public required SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    
    /// <summary>
    /// The financial institution that has submitted the data sets to the matching engine.
    /// </summary>
    [IsoId("_oioFMtE8Ed-BzquC8wXy7w_397445842")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public required BICIdentification1 Submitter { get; init; } 
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_oioFM9E8Ed-BzquC8wXy7w_403320313")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_oioFNNE8Ed-BzquC8wXy7w_403320018")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Commercial information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFNdE8Ed-BzquC8wXy7w_403319443")]
    [DisplayName("Commercial Data Set")]
    [IsoXmlTag("ComrclDataSet")]
    public CommercialDataSet3? CommercialDataSet { get; init; } 
    
    /// <summary>
    /// Transport information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFNtE8Ed-BzquC8wXy7w_403319768")]
    [DisplayName("Transport Data Set")]
    [IsoXmlTag("TrnsprtDataSet")]
    public TransportDataSet3? TransportDataSet { get; init; } 
    
    /// <summary>
    /// Insurance information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFN9E8Ed-BzquC8wXy7w_1316682998")]
    [DisplayName("Insurance Data Set")]
    [IsoXmlTag("InsrncDataSet")]
    public InsuranceDataSet1? InsuranceDataSet { get; init; } 
    
    /// <summary>
    /// Certificate information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oixPINE8Ed-BzquC8wXy7w_1650995885")]
    [DisplayName("Certificate Data Set")]
    [IsoXmlTag("CertDataSet")]
    public CertificateDataSet1? CertificateDataSet { get; init; } 
    
    /// <summary>
    /// Other certificate information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oixPIdE8Ed-BzquC8wXy7w_1469713115")]
    [DisplayName("Other Certificate Data Set")]
    [IsoXmlTag("OthrCertDataSet")]
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; } 
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_oixPItE8Ed-BzquC8wXy7w_403319846")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; } 
    
    
    #nullable disable
    
}


// Since ForwardDataSetSubmissionReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForwardDataSetSubmissionReportV03.

