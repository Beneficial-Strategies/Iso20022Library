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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForwardDataSetSubmissionReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForwardDataSetSubmissionReportV03( MessageIdentification1 reqReportIdentification,DataSetSubmissionReferences4 reqRelatedTransactionReferences,SimpleIdentificationInformation reqCommonSubmissionReference,BICIdentification1 reqSubmitter,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank )
    {
        ReportIdentification = reqReportIdentification;
        RelatedTransactionReferences = reqRelatedTransactionReferences;
        CommonSubmissionReference = reqCommonSubmissionReference;
        Submitter = reqSubmitter;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_oieUOdE8Ed-BzquC8wXy7w_403319072")]
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
    /// Identifies the transactions that this submission relates to and provides associated information.
    /// </summary>
    [IsoId("_oioFMNE8Ed-BzquC8wXy7w_403320811")]
    [DisplayName("Related Transaction References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdTxRefs")]
    #endif
    [IsoXmlTag("RltdTxRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetSubmissionReferences4 RelatedTransactionReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetSubmissionReferences4 RelatedTransactionReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetSubmissionReferences4 RelatedTransactionReferences { get; init; } 
    #else
    public DataSetSubmissionReferences4 RelatedTransactionReferences { get; set; } 
    #endif
    
    /// <summary>
    /// This reference must be used for all data sets belonging to the same submission group.
    /// </summary>
    [IsoId("_oioFMdE8Ed-BzquC8wXy7w_-1228245791")]
    [DisplayName("Common Submission Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonSubmissnRef")]
    #endif
    [IsoXmlTag("CmonSubmissnRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation CommonSubmissionReference { get; init; } 
    #else
    public SimpleIdentificationInformation CommonSubmissionReference { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution that has submitted the data sets to the matching engine.
    /// </summary>
    [IsoId("_oioFMtE8Ed-BzquC8wXy7w_397445842")]
    [DisplayName("Submitter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Submitr")]
    #endif
    [IsoXmlTag("Submitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 Submitter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 Submitter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 Submitter { get; init; } 
    #else
    public BICIdentification1 Submitter { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_oioFM9E8Ed-BzquC8wXy7w_403320313")]
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
    [IsoId("_oioFNNE8Ed-BzquC8wXy7w_403320018")]
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
    /// Commercial information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFNdE8Ed-BzquC8wXy7w_403319443")]
    [DisplayName("Commercial Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclDataSet")]
    #endif
    [IsoXmlTag("ComrclDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommercialDataSet3? CommercialDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommercialDataSet3? CommercialDataSet { get; init; } 
    #else
    public CommercialDataSet3? CommercialDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Transport information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFNtE8Ed-BzquC8wXy7w_403319768")]
    [DisplayName("Transport Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtDataSet")]
    #endif
    [IsoXmlTag("TrnsprtDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportDataSet3? TransportDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportDataSet3? TransportDataSet { get; init; } 
    #else
    public TransportDataSet3? TransportDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Insurance information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oioFN9E8Ed-BzquC8wXy7w_1316682998")]
    [DisplayName("Insurance Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncDataSet")]
    #endif
    [IsoXmlTag("InsrncDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceDataSet1? InsuranceDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceDataSet1? InsuranceDataSet { get; init; } 
    #else
    public InsuranceDataSet1? InsuranceDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oixPINE8Ed-BzquC8wXy7w_1650995885")]
    [DisplayName("Certificate Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertDataSet")]
    #endif
    [IsoXmlTag("CertDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificateDataSet1? CertificateDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateDataSet1? CertificateDataSet { get; init; } 
    #else
    public CertificateDataSet1? CertificateDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Other certificate information that has been submitted to the matching application by the other party.
    /// </summary>
    [IsoId("_oixPIdE8Ed-BzquC8wXy7w_1469713115")]
    [DisplayName("Other Certificate Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCertDataSet")]
    #endif
    [IsoXmlTag("OthrCertDataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; } 
    #else
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; set; } 
    #endif
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_oixPItE8Ed-BzquC8wXy7w_403319846")]
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


// Since ForwardDataSetSubmissionReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForwardDataSetSubmissionReportV03.

