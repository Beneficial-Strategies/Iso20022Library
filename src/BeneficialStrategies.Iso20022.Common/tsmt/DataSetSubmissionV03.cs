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
/// This record is an implementation of the tsmt.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DataSetSubmission message is sent by a party involved in the transaction to the matching application.
/// This message is used to trigger either a match or a pre-match of the information submitted with the message.
/// Usage
/// The DataSetSubmission message can be sent by either party with the instruction pre-match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to the requester of the data set pre-match by sending a DataSetMatchReport message.
/// or
/// The DataSetSubmission message can be sent by the party specified in the baseline as data set submitter with the instruction match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to
/// - the parties involved in a transaction established in the push-through mode, or
/// - the initiator of a transaction established in the lodge mode.
/// The DataSetSubmission message can be used to submit multiple data sets for multiple transactions (baselines) at the same time. However, all transactions (baselines) covered by the message must be for the same parties, that is transaction initiator and counterparty, as well as for the same buyer and seller.
/// The DataSetSubmission message consists of data reflecting trade information related to the purchasing agreement covered by the transaction(s), for example shipment date, invoice amount.
/// </summary>
[Description(@"Scope|The DataSetSubmission message is sent by a party involved in the transaction to the matching application.|This message is used to trigger either a match or a pre-match of the information submitted with the message.|Usage|The DataSetSubmission message can be sent by either party with the instruction pre-match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to the requester of the data set pre-match by sending a DataSetMatchReport message.|or|The DataSetSubmission message can be sent by the party specified in the baseline as data set submitter with the instruction match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to|- the parties involved in a transaction established in the push-through mode, or|- the initiator of a transaction established in the lodge mode.|The DataSetSubmission message can be used to submit multiple data sets for multiple transactions (baselines) at the same time. However, all transactions (baselines) covered by the message must be for the same parties, that is transaction initiator and counterparty, as well as for the same buyer and seller.|The DataSetSubmission message consists of data reflecting trade information related to the purchasing agreement covered by the transaction(s), for example shipment date, invoice amount.")]
[IsoId("_nQ9pAtE8Ed-BzquC8wXy7w_2054511397")]
[DisplayName("Data Set Submission V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataSetSubmissionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.014.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DataSetSubmissn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.014.001.03";
    
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
    /// Constructs a DataSetSubmissionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataSetSubmissionV03( MessageIdentification1 reqSubmissionIdentification,DataSetSubmissionReferences3 reqRelatedTransactionReferences,SimpleIdentificationInformation reqCommonSubmissionReference,InstructionType3 reqInstruction,BICIdentification1 reqBuyerBank,BICIdentification1 reqSellerBank )
    {
        SubmissionIdentification = reqSubmissionIdentification;
        RelatedTransactionReferences = reqRelatedTransactionReferences;
        CommonSubmissionReference = reqCommonSubmissionReference;
        Instruction = reqInstruction;
        BuyerBank = reqBuyerBank;
        SellerBank = reqSellerBank;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_nQ9pA9E8Ed-BzquC8wXy7w_2054512310")]
    [DisplayName("Submission Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmissnId")]
    #endif
    [IsoXmlTag("SubmissnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 SubmissionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 SubmissionIdentification { get; init; } 
    #else
    public MessageIdentification1 SubmissionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transactions that this submission relates to and provides associated information.
    /// </summary>
    [IsoId("_nQ9pBNE8Ed-BzquC8wXy7w_2054512233")]
    [DisplayName("Related Transaction References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdTxRefs")]
    #endif
    [IsoXmlTag("RltdTxRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; } 
    #else
    public DataSetSubmissionReferences3 RelatedTransactionReferences { get; set; } 
    #endif
    
    /// <summary>
    /// This reference must be used for all data sets belonging to the same submission group.
    /// </summary>
    [IsoId("_nQ9pBdE8Ed-BzquC8wXy7w_645845159")]
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
    /// Specifies the instruction given by the submitter.
    /// </summary>
    [IsoId("_nQ9pBtE8Ed-BzquC8wXy7w_2054512725")]
    [DisplayName("Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instr")]
    #endif
    [IsoXmlTag("Instr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionType3 Instruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructionType3 Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionType3 Instruction { get; init; } 
    #else
    public InstructionType3 Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nQ9pB9E8Ed-BzquC8wXy7w_2054511535")]
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
    [IsoId("_nQ9pCNE8Ed-BzquC8wXy7w_2054511830")]
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
    /// Commercial information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaANE8Ed-BzquC8wXy7w_2054511458")]
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
    /// Transport information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAdE8Ed-BzquC8wXy7w_2054512430")]
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
    /// Insurance information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAtE8Ed-BzquC8wXy7w_-215437655")]
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
    /// Certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaA9E8Ed-BzquC8wXy7w_-73215564")]
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
    /// Other certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaBNE8Ed-BzquC8wXy7w_1984114743")]
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
    
    
    #nullable disable
    
}


// Since DataSetSubmissionV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DataSetSubmissionV03.

