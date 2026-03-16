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
/// This record is an implementation of the pain.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(
    @"Scope|The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.|The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentReversal message can be used in domestic and cross-border scenarios."
)]
[IsoId("_GXBqeNEvEd-BzquC8wXy7w_-1340182044")]
[DisplayName("Customer Payment Reversal V")]
public record CustomerPaymentReversalV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pain.007.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.01";

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
    [IsoId("_GXBqedEvEd-BzquC8wXy7w_1971893603")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader8 GroupHeader { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_GXBqetEvEd-BzquC8wXy7w_-1325673423")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation5 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_GXBqe9EvEd-BzquC8wXy7w_-1906565683")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation4? TransactionInformation { get; init; }
}

// Since CustomerPaymentReversalV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerPaymentReversalV01.
