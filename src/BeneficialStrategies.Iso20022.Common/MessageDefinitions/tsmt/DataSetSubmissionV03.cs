// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

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
[Description(
    @"Scope|The DataSetSubmission message is sent by a party involved in the transaction to the matching application.|This message is used to trigger either a match or a pre-match of the information submitted with the message.|Usage|The DataSetSubmission message can be sent by either party with the instruction pre-match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to the requester of the data set pre-match by sending a DataSetMatchReport message.|or|The DataSetSubmission message can be sent by the party specified in the baseline as data set submitter with the instruction match. In the outlined scenario, the matching application will compare the data set(s) conveyed by the DataSetSubmission message with the established baseline and report the matching result to|- the parties involved in a transaction established in the push-through mode, or|- the initiator of a transaction established in the lodge mode.|The DataSetSubmission message can be used to submit multiple data sets for multiple transactions (baselines) at the same time. However, all transactions (baselines) covered by the message must be for the same parties, that is transaction initiator and counterparty, as well as for the same buyer and seller.|The DataSetSubmission message consists of data reflecting trade information related to the purchasing agreement covered by the transaction(s), for example shipment date, invoice amount."
)]
[IsoId("_nQ9pAtE8Ed-BzquC8wXy7w_2054511397")]
[DisplayName("Data Set Submission V")]
public record DataSetSubmissionV03 : IOuterRecord
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

    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_nQ9pA9E8Ed-BzquC8wXy7w_2054512310")]
    [DisplayName("Submission Identification")]
    [IsoXmlTag("SubmissnId")]
    public required MessageIdentification1 SubmissionIdentification { get; init; }

    /// <summary>
    /// Identifies the transactions that this submission relates to and provides associated information.
    /// </summary>
    [IsoId("_nQ9pBNE8Ed-BzquC8wXy7w_2054512233")]
    [DisplayName("Related Transaction References")]
    [IsoXmlTag("RltdTxRefs")]
    public required DataSetSubmissionReferences3 RelatedTransactionReferences { get; init; }

    /// <summary>
    /// This reference must be used for all data sets belonging to the same submission group.
    /// </summary>
    [IsoId("_nQ9pBdE8Ed-BzquC8wXy7w_645845159")]
    [DisplayName("Common Submission Reference")]
    [IsoXmlTag("CmonSubmissnRef")]
    public required SimpleIdentificationInformation CommonSubmissionReference { get; init; }

    /// <summary>
    /// Specifies the instruction given by the submitter.
    /// </summary>
    [IsoId("_nQ9pBtE8Ed-BzquC8wXy7w_2054512725")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public required InstructionType3 Instruction { get; init; }

    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nQ9pB9E8Ed-BzquC8wXy7w_2054511535")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; }

    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_nQ9pCNE8Ed-BzquC8wXy7w_2054511830")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; }

    /// <summary>
    /// Commercial information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaANE8Ed-BzquC8wXy7w_2054511458")]
    [DisplayName("Commercial Data Set")]
    [IsoXmlTag("ComrclDataSet")]
    public CommercialDataSet3? CommercialDataSet { get; init; }

    /// <summary>
    /// Transport information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAdE8Ed-BzquC8wXy7w_2054512430")]
    [DisplayName("Transport Data Set")]
    [IsoXmlTag("TrnsprtDataSet")]
    public TransportDataSet3? TransportDataSet { get; init; }

    /// <summary>
    /// Insurance information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaAtE8Ed-BzquC8wXy7w_-215437655")]
    [DisplayName("Insurance Data Set")]
    [IsoXmlTag("InsrncDataSet")]
    public InsuranceDataSet1? InsuranceDataSet { get; init; }

    /// <summary>
    /// Certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaA9E8Ed-BzquC8wXy7w_-73215564")]
    [DisplayName("Certificate Data Set")]
    [IsoXmlTag("CertDataSet")]
    public CertificateDataSet1? CertificateDataSet { get; init; }

    /// <summary>
    /// Other certificate information that is submitted to the matching application for processing.
    /// </summary>
    [IsoId("_nRHaBNE8Ed-BzquC8wXy7w_1984114743")]
    [DisplayName("Other Certificate Data Set")]
    [IsoXmlTag("OthrCertDataSet")]
    public OtherCertificateDataSet1? OtherCertificateDataSet { get; init; }
}

// Since DataSetSubmissionV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DataSetSubmissionV03.
