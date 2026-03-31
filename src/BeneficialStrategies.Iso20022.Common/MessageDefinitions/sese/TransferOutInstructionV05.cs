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
/// This record is an implementation of the sese.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.
/// This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.
/// Usage
/// The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party.
/// </summary>
[Description(
    @"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the TransferOutInstruction message to the executing party, for example, a transfer agent, to instruct the delivery of a financial instrument, free of payment, on a given date from a specified party.|This message may also be used to instruct the delivery of a financial instrument, free of payment, to another of the instructing parties own accounts or to a third party.|Usage|The TransferOutInstruction message is used to instruct the withdrawal of a financial instrument from one account and deliver it to either another account or to a third party."
)]
[IsoId("__fxhARXgEeOocOqSQt5Jbw")]
[DisplayName("Transfer Out Instruction V")]
public record TransferOutInstructionV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.001.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.001.001.05";

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
    [IsoId("__fxhBRXgEeOocOqSQt5Jbw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("__fxhBxXgEeOocOqSQt5Jbw")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("__fxhCRXgEeOocOqSQt5Jbw")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("__fxhCxXgEeOocOqSQt5Jbw")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("__fxhDRXgEeOocOqSQt5Jbw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Requested date at which the instructing party places the transfer instruction.
    /// </summary>
    [IsoId("__fxhDxXgEeOocOqSQt5Jbw")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("__fxhERXgEeOocOqSQt5Jbw")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer27 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("__fxhExXgEeOocOqSQt5Jbw")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount40 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("__fxhFRXgEeOocOqSQt5Jbw")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ReceiveInformation13? SettlementDetails { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_zukhgBw7EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("__fxhFxXgEeOocOqSQt5Jbw")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__fxhGRXgEeOocOqSQt5Jbw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferOutInstructionV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutInstructionV05.
