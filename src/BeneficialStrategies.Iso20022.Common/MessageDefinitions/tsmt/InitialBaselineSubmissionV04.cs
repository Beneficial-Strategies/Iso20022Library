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
/// This record is an implementation of the tsmt.019.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.
/// This message is used to initiate a transaction.
/// Usage
/// The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.
/// When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).
/// When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.
/// The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details.
/// </summary>
[Description(
    @"Scope|The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.|This message is used to initiate a transaction.|Usage|The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.|When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).|When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.|The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details."
)]
[IsoId("_7DK6cdNTEeK-v49t1oWkNA")]
[DisplayName("Initial Baseline Submission V")]
public record InitialBaselineSubmissionV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.019.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InitlBaselnSubmissn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.019.001.04";

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
    [IsoId("_7DK6ddNTEeK-v49t1oWkNA")]
    [DisplayName("Submission Identification")]
    [IsoXmlTag("SubmissnId")]
    public required MessageIdentification1 SubmissionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_7DK6d9NTEeK-v49t1oWkNA")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public required SimpleIdentificationInformation SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Specifies the instruction requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_7DK6edNTEeK-v49t1oWkNA")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public required InstructionType1 Instruction { get; init; }

    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_7DK6e9NTEeK-v49t1oWkNA")]
    [DisplayName("Baseline")]
    [IsoXmlTag("Baseln")]
    public required Baseline4 Baseline { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_7DK6fdNTEeK-v49t1oWkNA")]
    [DisplayName("Buyer Contact Person")]
    [IsoXmlTag("BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_7DK6f9NTEeK-v49t1oWkNA")]
    [DisplayName("Seller Contact Person")]
    [IsoXmlTag("SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the seller&apos;s bank or buyer&apos;s bank.
    /// </summary>
    [IsoId("_NtDmsDAaEeOKib24wnHaFg")]
    [DisplayName("Bank Contact Person")]
    [IsoXmlTag("BkCtctPrsn")]
    public required BankContactPerson1Choice_ BankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in another bank than seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_7DK6hdNTEeK-v49t1oWkNA")]
    [DisplayName("Other Bank Contact Person")]
    [IsoXmlTag("OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }
}

// Since InitialBaselineSubmissionV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InitialBaselineSubmissionV04.
