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
/// This record is an implementation of the sese.003.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.
/// This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner&apos;s account and its delivery to another own account, or to a third party, has taken place.
/// The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the TransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the delivery of a financial instrument, free of payment, on a given date, to a specified party.|This message may also be used to confirm the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutConfirmation message is used to confirm the withdrawal of a financial instrument from the owner's account and its delivery to another own account, or to a third party, has taken place.|The reference of the transfer confirmation is identified in TransferConfirmationReference. The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferOutInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference."
)]
[IsoId("_46sqcRXgEeOocOqSQt5Jbw")]
[DisplayName("Transfer Out Confirmation V")]
public record TransferOutConfirmationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.003.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.003.001.05";

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
    [IsoId("_46sqdxXgEeOocOqSQt5Jbw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_46sqeRXgEeOocOqSQt5Jbw")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_46sqexXgEeOocOqSQt5Jbw")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_46sqfRXgEeOocOqSQt5Jbw")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_46sqfxXgEeOocOqSQt5Jbw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_46sqgRXgEeOocOqSQt5Jbw")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer28 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_46sqgxXgEeOocOqSQt5Jbw")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount40 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_46sqhRXgEeOocOqSQt5Jbw")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ReceiveInformation12? SettlementDetails { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_861cwRw7EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_46sqhxXgEeOocOqSQt5Jbw")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_46sqiRXgEeOocOqSQt5Jbw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferOutConfirmationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutConfirmationV05.
