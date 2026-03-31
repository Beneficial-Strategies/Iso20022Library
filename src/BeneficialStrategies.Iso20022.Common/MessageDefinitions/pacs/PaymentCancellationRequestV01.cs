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
/// This record is an implementation of the pacs.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentCancellationRequest message is sent by the initiating party or any agent, to the next party in the payment chain. It is used to request the cancellation of an instruction previously sent.
/// Usage
/// The PaymentCancellationRequest message is exchanged between agents to request the cancellation of a payment message previously sent (i.e. FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit, and FinancialInstitutionCreditTransfer).
/// The PaymentCancellationRequest message can be used to request the cancellation of single instructions or multiple instructions, from one or multiple files.
/// The PaymentCancellationRequest message can be used in domestic and cross-border scenarios.
/// The PaymentCancellationRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The PaymentCancellationRequest message exchanged between agents is identified in the schema as follows: |urn: iso: std: iso: 20022: tech: xsd: pacs.006.001.01|.
/// </summary>
[Description(
    @"Scope|The PaymentCancellationRequest message is sent by the initiating party or any agent, to the next party in the payment chain. It is used to request the cancellation of an instruction previously sent.|Usage|The PaymentCancellationRequest message is exchanged between agents to request the cancellation of a payment message previously sent (i.e. FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit, and FinancialInstitutionCreditTransfer).|The PaymentCancellationRequest message can be used to request the cancellation of single instructions or multiple instructions, from one or multiple files.|The PaymentCancellationRequest message can be used in domestic and cross-border scenarios.|The PaymentCancellationRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The PaymentCancellationRequest message exchanged between agents is identified in the schema as follows: |urn: iso: std: iso: 20022: tech: xsd: pacs.006.001.01|."
)]
[IsoId("_eoSrcdEuEd-BzquC8wXy7w_-1218856998")]
[DisplayName("Payment Cancellation Request V")]
public record PaymentCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.006.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pacs.006.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.006.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eoccYNEuEd-BzquC8wXy7w_-45030390")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader7 GroupHeader { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_eoccYdEuEd-BzquC8wXy7w_1160897113")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation4 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_eoccYtEuEd-BzquC8wXy7w_1545316731")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation3? TransactionInformation { get; init; }
}

// Since PaymentCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentCancellationRequestV01.
