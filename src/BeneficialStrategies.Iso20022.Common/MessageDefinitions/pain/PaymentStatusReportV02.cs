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

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The PaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.
/// The PaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions (e.g. PaymentCancellationRequest).
/// The PaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The PaymentStatusReport message can be used in domestic and cross-border scenarios.
/// The PaymentStatusReport message exchanged between agents and non-financial institution customers is identified in the schema as follows: urn:iso:std:iso:20022:tech:xsd:pain.002.001.02.
/// </summary>
[Description(
    @"Scope|The PaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.|Usage|The PaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.|The PaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions (e.g. PaymentCancellationRequest).|The PaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The PaymentStatusReport message can be used in domestic and cross-border scenarios.|The PaymentStatusReport message exchanged between agents and non-financial institution customers is identified in the schema as follows: urn:iso:std:iso:20022:tech:xsd:pain.002.001.02."
)]
[IsoId("_GZkBENEvEd-BzquC8wXy7w_-408419624")]
[DisplayName("Payment Status Report V")]
public record PaymentStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.002.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pain.002.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.002.001.02";

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
    [IsoId("_GZkBEdEvEd-BzquC8wXy7w_-407499552")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader5 GroupHeader { get; init; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_GZkBEtEvEd-BzquC8wXy7w_-408419593")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public required OriginalGroupInformation1 OriginalGroupInformationAndStatus { get; init; }

    /// <summary>
    /// Information concerning the original transactions, to which the status report message refers.
    /// </summary>
    [IsoId("_GZkBE9EvEd-BzquC8wXy7w_-408419562")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public PaymentTransactionInformation1? TransactionInformationAndStatus { get; init; }
}

// Since PaymentStatusReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentStatusReportV02.
