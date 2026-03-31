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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.007.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.
/// This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// This message may also be used as an advice, that is, the message is used to provide account information.
/// Usage
/// The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.
/// The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the TransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.|This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|This message may also be used as an advice, that is, the message is used to provide account information.|Usage|The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.|The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference."
)]
[IsoId("_9RtIcR8NEeWpZde3LQh6dg")]
[DisplayName("Transfer In Confirmation V")]
public record TransferInConfirmationV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.007.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_9RtIdx8NEeWpZde3LQh6dg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_9RtIeR8NEeWpZde3LQh6dg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference6? PoolReference { get; init; }

    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_9RtIex8NEeWpZde3LQh6dg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference6? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9RtIfR8NEeWpZde3LQh6dg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference6? RelatedReference { get; init; }

    /// <summary>
    /// Function of the transfer in, that is, whether the transfer in message is used as a confirmation or as or an advice. The absence of Function indicates the message is a confirmation.
    /// </summary>
    [IsoId("_NayL4SVQEeWI0orciOKunQ")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction2Code? Function { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_9RtIfx8NEeWpZde3LQh6dg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_9RtIgR8NEeWpZde3LQh6dg")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer33 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_9RtIgx8NEeWpZde3LQh6dg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount56 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_9RtIhR8NEeWpZde3LQh6dg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public DeliverInformation17? SettlementDetails { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9RtIhx8NEeWpZde3LQh6dg")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_9RtIiR8NEeWpZde3LQh6dg")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9RtIix8NEeWpZde3LQh6dg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferInConfirmationV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInConfirmationV07.
