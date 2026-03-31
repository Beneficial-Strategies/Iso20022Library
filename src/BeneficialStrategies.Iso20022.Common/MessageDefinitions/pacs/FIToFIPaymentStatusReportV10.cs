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

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.002.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FIToFIPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The FIToFIPaymentStatusReport message is exchanged between agents to provide status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The FIToFIPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).
/// The FIToFIPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentStatusReport message can be used in domestic and cross-border scenarios.
/// The FIToFIPaymentStatusReport may also be sent to the receiver of the payment in a real time payment scenario, as both sides of the transactions must be informed of the status of the transaction (for example either the beneficiary is credited, or the transaction is rejected).
/// </summary>
[Description(
    @"Scope|The FIToFIPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.|Usage|The FIToFIPaymentStatusReport message is exchanged between agents to provide status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.|The FIToFIPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).|The FIToFIPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentStatusReport message can be used in domestic and cross-border scenarios.|The FIToFIPaymentStatusReport may also be sent to the receiver of the payment in a real time payment scenario, as both sides of the transactions must be informed of the status of the transaction (for example either the beneficiary is credited, or the transaction is rejected)."
)]
[IsoId("_x0JYx3L4EeidQ_AAdEzxQA")]
[DisplayName("FI To FI Payment Status Report V")]
public record FIToFIPaymentStatusReportV10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.002.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.002.001.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status report message.
    /// </summary>
    [IsoId("_x0JY2XL4EeidQ_AAdEzxQA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader91 GroupHeader { get; init; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_x0JY23L4EeidQ_AAdEzxQA")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public OriginalGroupHeader17? OriginalGroupInformationAndStatus { get; init; }

    /// <summary>
    /// Information concerning the original transactions, to which the status report message refers.
    /// </summary>
    [IsoId("_x0JY3XL4EeidQ_AAdEzxQA")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransaction110? TransactionInformationAndStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_x0JY33L4EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since FIToFIPaymentStatusReportV10Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FIToFIPaymentStatusReportV10.
