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
/// This record is an implementation of the pain.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor&apos;s account(s) for a creditor.
/// Usage
/// The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.
/// The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.
/// If it is agreed to include the payment information related to the credit side only once (i.e. Grouped mode), the PaymentInformation block will be present only once. If it is agreed to repeat the payment information related to the credit side (i.e. Single mode), the PaymentInformation block must be present once per occurrence of the DirectDebitTransactionInformation block. The CustomerDirectDebitInitiation message also allows for a Mixed mode where the PaymentInformation block can be repeated and each PaymentInformation block can contain one or several DirectDebitTransactionInformation block(s).|Single|When grouping is set to Single, information for each individual instruction is included separately. This means the|PaymentInformation block is repeated, and present for each occurrence of the Direct Debit TransactionInformation block.|Grouped|When grouping is set to Grouped, the PaymentInformation block will be present once and the Direct Debit|TransactionInformation block will be repeated.|Mixed|When grouping is set to Mixed, the PaymentInformation block may be present once or may be repeated. Each sequence|of the PaymentInformation block may contain one or several Direct Debit TransactionInformation block(s).
/// </summary>
[Description(
    @"Scope|The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor's account(s) for a creditor.|Usage|The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.|- In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.|The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.|The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.|The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.|If it is agreed to include the payment information related to the credit side only once (i.e. Grouped mode), the PaymentInformation block will be present only once. If it is agreed to repeat the payment information related to the credit side (i.e. Single mode), the PaymentInformation block must be present once per occurrence of the DirectDebitTransactionInformation block. The CustomerDirectDebitInitiation message also allows for a Mixed mode where the PaymentInformation block can be repeated and each PaymentInformation block can contain one or several DirectDebitTransactionInformation block(s).|Single|When grouping is set to Single, information for each individual instruction is included separately. This means the|PaymentInformation block is repeated, and present for each occurrence of the Direct Debit TransactionInformation block.|Grouped|When grouping is set to Grouped, the PaymentInformation block will be present once and the Direct Debit|TransactionInformation block will be repeated.|Mixed|When grouping is set to Mixed, the PaymentInformation block may be present once or may be repeated. Each sequence|of the PaymentInformation block may contain one or several Direct Debit TransactionInformation block(s)."
)]
[IsoId("_GWuvhdEvEd-BzquC8wXy7w_143996786")]
[DisplayName("Customer Direct Debit Initiation V")]
public record CustomerDirectDebitInitiationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.008.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pain.008.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.01";

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
    [IsoId("_GWuvhtEvEd-BzquC8wXy7w_143996882")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader1 GroupHeader { get; init; }

    /// <summary>
    /// Set of characteristics that apply to the credit side of the payment transactions included in the direct debit transaction initiation.
    /// </summary>
    [IsoId("_GWuvh9EvEd-BzquC8wXy7w_144917422")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    public required PaymentInstructionInformation2 PaymentInformation { get; init; }
}

// Since CustomerDirectDebitInitiationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerDirectDebitInitiationV01.
