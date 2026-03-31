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
/// This record is an implementation of the pacs.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.
/// The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.
/// The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
///
/// </summary>
[Description(
    @"Scope|The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.|The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.|The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.|"
)]
[IsoId("_elKe5dEuEd-BzquC8wXy7w_-1796587382")]
[DisplayName("FI To FI Payment Reversal V")]
public record FIToFIPaymentReversalV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pacs.007.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.007.001.01";

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
    [IsoId("_elKe5tEuEd-BzquC8wXy7w_421348727")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader9 GroupHeader { get; init; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_elKe59EuEd-BzquC8wXy7w_357436312")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation5 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_elKe6NEuEd-BzquC8wXy7w_-191011416")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    public PaymentTransactionInformation5? TransactionInformation { get; init; }
}

// Since FIToFIPaymentReversalV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FIToFIPaymentReversalV01.
